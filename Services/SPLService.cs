//using Newtonsoft.Json;
//using SPL.Common;
//using SPL.Models;
//using SPL.Models.Dto;
//using SPL.Models.ResultDto;
//using SPL.Models.SPLProcessResult;
//using SPL.Repositories.IRepositories;
//using SPL.Services.IServices;
//using System.Runtime.Intrinsics.Arm;
//using System.Text.RegularExpressions;

//namespace SPL.Services
//{
//    public class SPLService : ISPLService
//    {
//        private readonly IUserRepository _userRepository;
//        private readonly IPDStationRepository _pDStationRepository;
//        private readonly int defaultCells = 5;

//        public SPLService(IUserRepository userRepository, IPDStationRepository pDStationRepository)
//        {
//            _userRepository = userRepository;
//            _pDStationRepository = pDStationRepository;
//        }

//        public async Task<SPLProcessResultDto> SPLBoxBind(SPLBoxBindDto data)
//        {
//            string Msg = JsonConvert.SerializeObject(data);

//            try
//            {
//                var serverCellsByCells = new List<PDTrace>();
//                List<string> StatusCodes = new List<string>();
//                List<string> Results = new List<string>();
//                DateTime beginTime = DateTime.Now;
//                var productCode = "";
//                var stypeCode = "";
//                string strCellType = "OFF";

//                Regex regexBoxSn = new Regex(@"^([A-Z]{3}|[A-Z]{4})\d{1}[A-Z]{1}\d{5}-\d{3}$");
//                Regex regexProduct = new Regex(@"^[A-Z]{3}\d{2}[A-Z]{1}\d{2}[A-Z]{5}\d{6}");
//                if (!regexBoxSn.IsMatch(data.BoxSN))
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！【托盘号】规则不正确。" };
//                for (int i = 0; i < data.LstProductSN.Count; i++)
//                {
//                    if (!regexProduct.IsMatch(data.LstProductSN[i].ProductSN))
//                        return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！【电芯码】规则不正确。" };
//                }

//                if (string.IsNullOrEmpty(data.BoxSN))
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！请提供【托盘号】。" };
//                if (string.IsNullOrEmpty(data.StationCode))
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 请提供【工艺编号】。" };
//                if (string.IsNullOrEmpty(data.LineCode))
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 请提供【线体编号】。" };
//                if (data.LstProductSN == null || data.LstProductSN.Count == 0)
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 请提供电芯明细数据。" };
//                if (data.LstProductSN.Count != defaultCells)
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 电芯数量({data.LstProductSN.Count})异常。" };

//                if (data.LstProductSN.Select(c => c.ProductSN).Distinct().Count() != defaultCells)
//                {
//                    foreach (var product in data.LstProductSN)
//                    {
//                        var otherIndex = data.LstProductSN.Find(c => c.ProductSN == product.ProductSN && c.BoxIndex != product.BoxIndex);
//                        if (otherIndex != null)
//                            return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 位置:{product.BoxIndex} 和 位置:{otherIndex.BoxIndex} 位置电芯码重复。" };
//                    }
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 电芯码存在重复。" };
//                }

//                productCode = _sPLApi_Public.GetProductCode(data.LstProductSN.Select(c => c.ProductSN).ToList());
//                if (string.IsNullOrEmpty(productCode))
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 电芯存在多种型号。" };

//                var line = await _pd_LineProcess.FirstOrDefaultAsync(c =>
//                    c.ProductCode == productCode && c.StationCode == data.StationCode && (c.LineCode == data.LineCode || c.LineCode == "public"));
//                if (line == null)
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！工艺编号:{data.StationCode} 线别:{data.LineCode} 产品类型:{productCode} 匹配不到【线体】。" };

//                var stations = line.isOpen == "Y";
//                if (!stations)
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！工艺编号:{data.StationCode} 工序不在流程内。" };

//                var type = line.CellType.Contains(strCellType);
//                if (!type)
//                {
//                    var pro = _sPLApi_Public.GetTypeCode(data.LstProductSN.Select(c => c.ProductSN).ToList(), line.CellType, line.DisCellTypes);
//                    stypeCode = pro.a;
//                    if (string.IsNullOrEmpty(pro.a))
//                        return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 该托盘存在无配置的电芯类型,请检查电芯:{pro.b}。" };
//                }


//                var dataCells = data.LstProductSN.Select(c => c.ProductSN).ToList();
//                serverCellsByCells = await _pd_Trace.Where(c => dataCells.Contains(c.ProductSN)).ToListAsync();
//                if (serverCellsByCells.Count != defaultCells)
//                {
//                    var diffList = new List<string>();
//                    foreach (var product in data.LstProductSN)
//                    {
//                        if (!serverCellsByCells.Exists(c => c.ProductSN == product.ProductSN))
//                        {
//                            if (_sPLApi_Public.PassCellRegex(product.ProductSN)) // 假电芯不上线                   
//                                continue;

//                            diffList.Add(product.ProductSN + $"(位置:{product.BoxIndex})");
//                        }
//                    }
//                    if (diffList.Count > 0)
//                        return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 电芯:{string.Join(";", diffList)} 未上线。" };
//                }


//                var serverCellsByBoxID = await _pDStationRepository..Where(c => c.BoxSN == data.BoxSN).ToListAsync();

//                foreach (var cell in serverCellsByCells)
//                {
//                    var diffStationList = new List<string>();
//                    if (cell.StationCode != data.StationCode)
//                        diffStationList.Add(cell.ProductSN + $"(当前工艺:{cell.StationCode})");
//                    if (diffStationList.Count > 0)
//                        return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 电芯:{string.Join(";", diffStationList)} 与绑盘工艺:{data.StationCode}不一致。" };
//                }

//                var status = serverCellsByCells.Where(c => c.StatusCode == serverCellsByCells[0].StatusCode).ToList();
//                for (int i = 0; i < serverCellsByCells.Count; i++)
//                {
//                    if (serverCellsByCells[i].StatusCode != serverCellsByCells[0].StatusCode)
//                        return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！ {serverCellsByCells[i].ProductSN}电芯状态不一致。" };
//                }
//                //if (status.Count != defaultCells)
//                //    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 电芯状态不一致。" };

//                if (serverCellsByCells.Exists(c => !string.IsNullOrEmpty(c.BoxSN)))
//                {
//                    string productSnMessage = "";
//                    foreach (var product in serverCellsByCells)
//                    {
//                        if (!string.IsNullOrEmpty(product.BoxSN))
//                        {
//                            var productT = data.LstProductSN.Find(c => c.ProductSN == product.ProductSN);
//                            productSnMessage += $"位置:{productT?.BoxIndex} 已绑定托盘:{product.BoxSN};";
//                        }
//                    }
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！{productSnMessage}。" };
//                }

//                if (serverCellsByBoxID.Count > 0)
//                {
//                    return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！托盘号:{data.BoxSN} 已存在绑盘电芯。" };
//                }
//                await SendToWms();

//                await addWIP();

//                TimeSpan time = DateTime.Now - beginTime;
//                string csvData = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "," + data.BoxSN + "," + "" + "," + time + "," + "" + ":" + $"绑盘成功。" + "," + Msg;
//                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Csv\{0}\{1}\SPLBoxBind\{2}\SPLBoxBind {3}时", DateTime.Now.ToString("yyyyMM"), DateTime.Now.ToString("yyyyMMdd"), data.DeviceCode, DateTime.Now.ToString("HH")));
//                string headline = "时间,托盘码,反馈结果,耗时,MES返回结果,上传内容";
//                File_Txt_Helper.WriteLogCSV(csvData + "\n", path, headline);
//                double total = time.TotalSeconds;
//                if (total > 1)
//                {
//                    File_Txt_Helper.WriteLogTxt(string.Format("BoxSN:{0};Time:{1};Station:{2}\r\n", data.BoxSN, total, data.StationCode), "TimeOut_SPLBoxBind", data.StationCode);
//                }
//                return new SPLProcessResultDto() { Success = true, Message = "绑盘成功。" };

//                //更新在线表 和插入记录
//                async Task addWIP()
//                {
//                    File_Txt_Helper.WriteLogTxt("Trace.UpdateAsync:1" + data.BoxSN, "SPLBoxBind", data.StationCode);
//                    foreach (var newProduct in data.LstProductSN)
//                    {
//                        var oldProduct = serverCellsByCells.Find(c => c.ProductSN == newProduct.ProductSN);
//                        if (oldProduct == null)
//                            continue;

//                        oldProduct.DeviceName = line.DeviceName;
//                        oldProduct.BoxSN = data.BoxSN;
//                        oldProduct.BoxIndex = newProduct.BoxIndex;
//                        oldProduct.LineCode = data.LineCode;      // 这个参数来源需要调整，SPL必须增加限制参数
//                        oldProduct.StationCode = oldProduct?.StationCode;
//                        oldProduct.DeviceCode = data.DeviceCode;
//                        oldProduct.ProductCode = productCode;
//                        oldProduct.Remark = "电芯绑盘";
//                        oldProduct.TransTime = data.TransTime;
//                        oldProduct.UID = data.UID;
//                        oldProduct.SysTime = DateTime.Now;
//                        await _pd_Trace.UpdateAsync(oldProduct);

//                    }
//                    File_Txt_Helper.WriteLogTxt($"Trace.UpdateAsync:2" + data.BoxSN, "SPLBoxBind", data.StationCode);

//                    #region--缓存表按月份添加缓存0408
//                    for (int i = 0; i < data.LstProductSN.Count; i++)
//                    {
//                        var oldProduct = serverCellsByCells.Find(c => c.ProductSN == data.LstProductSN[i].ProductSN);
//                        StatusCodes.Add(oldProduct.StatusCode);
//                        Results.Add(oldProduct.PResult);
//                    }

//                    string sql = $@"if object_id('tempdb..#tbTempTableDataWIPB1') is not null
//                                		begin
//                                			drop table #tbTempTableDataWIPB1
//                                		end
//                                	   create table #tbTempTableDataWIPB1
//                                		(	
//                                			 ID varchar(50) ,
//			                                 LineCode varchar(50),
//			                                 DeviceName varchar(50),
//			                                 StationCode varchar(50),
//		                                     DeviceCode varchar(50),
//		                                     ProductCode varchar(50),
//			                                 BoxSN varchar(50),
//	 		                                 BoxIndex int,
//			                                 ProductSN varchar(50) PRIMARY KEY,
//			                                 PResult varchar(50),
//			                                 StatusCode varchar(50),
//			                                 Remark varchar(50),
//			                                 TransTime varchar(50),
//			                                 UID varchar(50),
//			                                 SysTime varchar(50)  
//                                    	)			
//                                		declare @tempBoxIndex varchar(50)
//                                        declare @tempStatus varchar(50)
//		                                declare @tempProductSN varchar(50)
//		                                declare @tempResult varchar(50)
//		                                declare @next int 
//		                                declare @length int 
//		                                declare @sql1 nvarchar(max)		
//		                                declare @nowTime varchar(50)
//		                                declare @tablename varchar(50)
//		                                set @nowTime=convert(varchar,getdate(),21)
//		                                set @tablename='[dbo].[PD_WIP_'+DATENAME(yyyy,GETDATE())+DATENAME(MM,GETDATE())+']'
//		                                set @sql1 =  'insert into '+ @tablename +' select * from #tbTempTableDataWIPB1'
//		                                select @sql1;
//		                                set @next=1
//		                                set @length = dbo.Get_StrArrayLength('{string.Join(",", data.LstProductSN.Select(x => x.ProductSN).ToArray())}', ',')
//                                		while @next<=@length
//                                		begin		     
//                                			  set @tempProductSN = dbo.Get_StrArrayStrOfIndex('{string.Join(",", data.LstProductSN.Select(x => x.ProductSN).ToArray())}', ',', @next)
//                                              set @tempBoxIndex = dbo.Get_StrArrayStrOfIndex('{string.Join(",", data.LstProductSN.Select(x => x.BoxIndex).ToArray())}', ',', @next)
//                                              set @tempStatus = dbo.Get_StrArrayStrOfIndex('{string.Join(",", StatusCodes.ToArray())}', ',', @next)
//                                              set @tempResult = dbo.Get_StrArrayStrOfIndex('{string.Join(",", Results.ToArray())}', ',', @next)
//                                	insert into #tbTempTableDataWIPB1 (ID,LineCode,DeviceName,StationCode,DeviceCode,ProductCode,BoxSN,BoxIndex,ProductSN,
//		 	                           PResult,StatusCode,Remark,TransTime,UID,SysTime)
//			  values(newid(),'{data.LineCode}','{line.DeviceName}','{data.StationCode}','{data.DeviceCode}','{productCode}','{data.BoxSN}',@tempBoxIndex,@tempProductSN,
//                                                            @tempResult,@tempStatus,'{"电芯绑盘"}','{data.TransTime}','{data.UID}',
//                                   @nowTime);
//		  	  set @next=@next+1;
//                                		end
//                                		exec (@sql1)
                                		
//                                ";
//                    File_Txt_Helper.WriteLogTxt("WIP.InsertAsync:3" + data.BoxSN, "SPLBoxBind", data.StationCode);
//                    var entity1 = await Dp.QueryAsync<object>(sql);
//                    File_Txt_Helper.WriteLogTxt("WIP.InsertAsync:4" + data.BoxSN, "SPLBoxBind", data.StationCode);
//                    #endregion
//                }

//                //校验


//                //同步给WMS
//                async Task<string> SendToWms()
//                {
//                    var allProcess = await _pd_LineProcess.Where(c => c.ProductCode == productCode && (c.LineCode == data.LineCode || c.LineCode == "public")).ToListAsync();
//                    var lastStation = _sPLApi_Public.GetLastStationCode(allProcess, productCode, data.LineCode, data.StationCode);
//                    //File_Txt_Helper.WriteLogTxt("BoxTechnology.FirstOrDefaultAsync:1 " + data.BoxSN, "SPLBoxBind", data.StationCode);
//                    var entity = await _pd_BoxTechnology.FirstOrDefaultAsync(_ => _.BoxSN == data.BoxSN);
//                    //File_Txt_Helper.WriteLogTxt("BoxTechnology.FirstOrDefaultAsync:2 " + data.BoxSN, "SPLBoxBind", data.StationCode);
//                    string nextStation = _sPLApi_Public.GetNextStationCode(allProcess, productCode, data.LineCode, serverCellsByCells[0].StationCode);

//                    WMSBoxInfoSyncDto wmsData = new WMSBoxInfoSyncDto();
//                    wmsData.LstProductSN = new List<SNDetail>();
//                    wmsData.ProductCode = productCode;
//                    wmsData.ProductType = stypeCode;
//                    wmsData.LineCode = data.LineCode;
//                    wmsData.StationCode = data.StationCode;
//                    wmsData.BoxSN = data.BoxSN;
//                    wmsData.NextStationCode = nextStation;
//                    wmsData.Technology = entity != null ? entity.Technology : "0";
//                    for (int j = 0; j < data.LstProductSN.Count(); j++)
//                    {
//                        var v = new SNDetail
//                        {
//                            BoxIndex = data.LstProductSN[j].BoxIndex,
//                            ProductSN = data.LstProductSN[j].ProductSN.Trim(),
//                            PResult = "OK"
//                        };
//                        wmsData.LstProductSN.Add(v);
//                    }
//                    string postData = JsonConvert.SerializeObject(wmsData);
//                    File_Txt_Helper.WriteLogTxt("JSON" + postData, "SPLBoxBind", "WMSBoxInfoSyncJSON");
//                    DateTime beginTime_MMS = DateTime.Now;
//                    var resultWMS = await WebApiClient.DoPost(boxInfoSyncUrl, postData);
//                    var result = JsonConvert.DeserializeObject<WMSBoxInfoSyncResultDto>(resultWMS ?? "{}");
//                    if (result != null)
//                    {
//                        TimeSpan time_WMS = DateTime.Now - beginTime_MMS;
//                        double total_WMS = time_WMS.TotalSeconds;
//                        if (total_WMS > 1)
//                            File_Txt_Helper.WriteLogTxt(string.Format("WMS同步BoxSN:{0};Time:{1};Station:{2}\r\n", data.BoxSN, total_WMS, data.StationCode), "TimeOut_SPLBoxBind", data.StationCode);

//                        return result.Message;
//                    }
//                    else
//                    {
//                        return "WMS同步失败！网络异常！";
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                File_Txt_Helper.WriteCatchLog(string.Format("BoxSN:{0};MessageInfo:{1};JSON:{2}\r\n\r\n", data.BoxSN, ex.ToString(), Msg), "SPLBoxBind", "Exception-SPLBoxBind");
//                return new SPLProcessResultDto() { Success = false, Code = "", Message = $"绑盘失败！异常：{ex.ToString()}。" };
//            }
//        }

//        public async Task<SPLProcessResultDto> SPLBoxIn(SPLBoxInDto data)
//        {
//            DateTime beginTime = DateTime.Now;
//            bool success = true;
//            string code = "000";
//            string message = "";
//            string Msg = JsonConvert.SerializeObject(data);
//            string strTempProductCode = "";
//            string strCellType = "OFF";
//            string strType = "";
//            List<string> ProductSN = new List<string>();
//            List<int> Index = new List<int>();
//            try
//            {
//                Regex regexBoxSN = new Regex(@"^([A-Z]{3}|[A-Z]{4})\d{1}[A-Z]{1}\d{5}-\d{3}$");
//                Regex regexProduct = new Regex(@"^[A-Z]{3}\d{2}[A-Z]{1}\d{2}[A-Z]{5}\d{6}");
//                if (!regexBoxSN.IsMatch(data.BoxSN)
//                {
//                    code = "101";
//                    message = "托盘码规则不正确：" + data.BoxSN;
//                }

//                // 获取站点信息
//                var vStation = await _pDStationRepository.GetStationInfoAsync(data.BoxSN);
//                FileTxtHelper.WriteLogTxt("Trace.Where:1" + data.BoxSN, "SPLBoxIn", data.StationCode);

//                // 获取电芯信息
//                var vLsBoxTrace = await _pDStationRepository.GetTraceInfoAsync(data.BoxSN);
//                FileTxtHelper.WriteLogTxt("Trace.Where:2" + data.BoxSN, "SPLBoxIn", data.StationCode);

//                if (vStation.IsIn != "ON")
//                {
//                    if (vLsBoxTrace != null || vLsBoxTrace.Count == 0)
//                    {
//                        code = "201";
//                        message = "在线数据异常！无绑定数据！托盘号:" + data.BoxSN;
//                    }
//                    else if (vLsBoxTrace.Count != 5)
//                    {
//                        code = "202";
//                        message = "在线数据异常！电芯数量异常！数据条数：" + vLsBoxTrace.Count + "！托盘号：" + data.BoxSN;
//                    }
//                    else
//                    {
//                        strTempProductCode = vLsBoxTrace[0].ProductCode;
//                        strType = vLsBoxTrace[0].ProductSN.Substring(5, 7);
//                    }
//                }
//                else
//                {
//                    for (int i = 0; i < data.LstProductSN.Count; i++)
//                    {
//                        if (!regexProduct.IsMatch(data.LstProductSN[i].ProductSN))
//                        {
//                            code = "102";
//                            message = "电芯码规则不正确:" + data.LstProductSN[i].ProductSN;
//                            break;
//                        }
//                    }
//                    if (data.LstProductSN == null)
//                    {
//                        code = "105";
//                        message = "上传数据格式错误！电芯数据为空！托盘号为：" + data.BoxSN;
//                    }
//                    else if (data.LstProductSN.Count != 5)
//                    {
//                        code = "106";
//                        message = "上传数据格式错误！电芯数量异常！数据条数为：" + data.LstProductSN.Count + "，托盘号为：" + data.BoxSN;
//                    }
//                    else
//                    {
//                        var vLstProductSN = data.LstProductSN.GroupBy(n => n.ProductSN).Select(n => n.First()).ToList();

//                        var vLstProductSNLengthError = data.LstProductSN.Where(x => x.ProductSN.Length != 19).ToList();

//                        if (vLstProductSN.Count != data.LstProductSN.Count)
//                        {
//                            code = "108";
//                            message = "上传数据格式错误！出现重复电芯码！托盘号为：" + data.BoxSN;
//                        }
//                        else if (vLstProductSNLengthError.Count != 0)
//                        {
//                            code = "109";
//                            message = "上传数据格式错误！电芯码长度异常集合：" + string.Join(",", vLstProductSNLengthError) + "！托盘号为：" + data.BoxSN;
//                        }

//                        strTempProductCode = ("1" + data.LstProductSN[0].ProductSN.Substring(6, 2));

//                        for (int i = 0; i < data.LstProductSN.Count; i++)
//                        {
//                            if (("1" + data.LstProductSN[i].ProductSN.Substring(6, 2)) != strTempProductCode)
//                            {
//                                code = "110";
//                                message = "上传数据异常！电芯产品类型不一致，请检查电芯：" + data.LstProductSN[i].ProductSN + "！托盘号为：" + data.BoxSN; ;
//                                break;
//                            }
//                        }

//                        strType = data.LstProductSN[0].ProductSN.Substring(5, 7);
//                    }
//                }

//                if (code == "000")
//                {
//                    var vLstLineProcess = (await _pDStationRepository.GetLineProcessInfoAsync(data.StationCode, data.LineCode));
                    
//                    var vLstLine = vLstLineProcess.Where(_ => _.ProductCode == strTempProductCode).ToList();

//                    var vLstLineCellType = vLstLine.Where(_ => _.CellType.Contains(strCellType)).ToList();

//                    var vLstFormulasProcess = (await _pDStationRepository.GetFormulasProcessInfoAsync(strTempProductCode)).OrderBy(_ => _.SN).ToList();

//                    var vMFormulasStation = vLstFormulasProcess.FindAll(_ => _.StationCode == data.StationCode);

//                    if (vLstLineProcess.Count == 0)
//                    {
//                        code = "301";
//                        message = "配置检验失败！无该电芯产品类型：" + strTempProductCode + "！托盘号:" + data.BoxSN;
//                    }
//                    else if (vLstLine.Count == 0)
//                    {
//                        code = "302";
//                        message = "配置检验失败！该工序配置无该电芯产品类型：" + strTempProductCode + "！托盘号:" + data.BoxSN;
//                    }
//                    else if (vMFormulasStation.Count == 0)
//                    {
//                        code = "304";
//                        message = "配置检验失败！当前工序不在当前的流程内，请确认当前的工艺流程！托盘号:" + data.BoxSN;
//                    }
//                    if (code == "000")
//                    {
//                        if (vLstLineCellType.Count == 0)
//                        {
//                            if (code == "000" && vStation.IsIn == "ON")
//                            {
//                                if (vLstLine[0].CellType.Contains(data.LstProductSN[0].ProductSN.Substring(5, 7)))
//                                {
//                                    for (int i = 0; i < data.LstProductSN.Count; i++)
//                                    {
//                                        if (!vLstLine[0].CellType.Contains(data.LstProductSN[i].ProductSN.Substring(5, 7)))
//                                        {
//                                            code = "111";
//                                            message = "上传数据异常！电芯型号不一致，存在加厚电芯无配置型号，请检查电芯：" + data.LstProductSN[i].ProductSN + "！托盘号为：" + data.BoxSN;
//                                            break;
//                                        }
//                                    }
//                                }
//                                else if (vLstLine[0].DisCellType.Contains(data.LstProductSN[0].ProductSN.Substring(5, 7)))
//                                {
//                                    for (int i = 0; i < data.LstProductSN.Count; i++)
//                                    {
//                                        if (!vLstLine[0].DisCellType.Contains(data.LstProductSN[i].ProductSN.Substring(5, 7)))
//                                        {
//                                            code = "111";
//                                            message = "上传数据异常！电芯型号不一致，存在非加厚电芯无配置型号，请检查电芯：" + data.LstProductSN[i].ProductSN + "！托盘号为：" + data.BoxSN;
//                                            break;
//                                        }
//                                    }
//                                }
//                                else
//                                {
//                                    code = "111";
//                                    message = "上传数据异常！电芯型号无该配置，请检查电芯：" + data.LstProductSN[0].ProductSN + "！托盘号为：" + data.BoxSN;
//                                }
//                            }
//                        }
//                    }

//                    if (code == "000")
//                    {
//                        if (data.StationCode == vLstFormulasProcess[0].StationCode)
//                        {
//                            // 首工序
//                            var oldLstProductSN = new List<ObjProductSN>();
//                            var vStartStatusTrace = vLsBoxTrace.FindAll(x => x.StatusCode == "START");
//                            if (vLsBoxTrace.Count != 0 && vStartStatusTrace.Count == 0)
//                            {
//                                code = "401";
//                                message = "该托盘已经在线上绑定了，首工序进站失败！托盘号：" + data.BoxSN;
//                            }
//                            else if (vLsBoxTrace.Count != 0 && vStartStatusTrace.Count != data.LstProductSN.Count)
//                            {
//                                code = "404";
//                                message = "该托盘有电芯被更换,请解绑后重新绑盘" + data.BoxSN;
//                            }

//                            if (code == "000")
//                            {
//                                var pSns = data.LstProductSN.Select(x => x.ProductSN);
//                                var pdList = await _pDStationRepository.GetByProductSNAsync(pSns);
//                                for (int i = 0; i < data.LstProductSN.Count; i++)
//                                {
//                                    var vTraceProductSN = pdList.FirstOrDefault(_ => _.ProductSN == data.LstProductSN[i].ProductSN);
//                                    if (vTraceProductSN != null && vTraceProductSN.StatusCode != "START")
//                                    {
//                                        var tempProductSN = new ObjProductSN();
//                                        tempProductSN.BoxIndex = data.LstProductSN[i].BoxIndex;
//                                        tempProductSN.ProductSN = data.LstProductSN[i].ProductSN;
//                                        oldLstProductSN.Add(tempProductSN);
//                                    }
//                                }
//                                if (oldLstProductSN != null && oldLstProductSN.Count > 0)
//                                {
//                                    code = "402";
//                                    message = "存在部分电芯已经进入流程，且状态不为START，首工序进站失败！" + string.Join(",", oldLstProductSN.Select(x => x.ProductSN).ToArray());
//                                }
//                                if (code == "000")
//                                {

//                                }
//                            }
//                        }

//                    }
//                }

//            }
//        }

//        public Task<SPLProcessResultDto> SPLBoxOnlineStationOver(SPLBoxStationOverDto data)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<SPLProcessResultDto> SPLBoxOut(SPLBoxOutDto data)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<SPLProcessResultDto> SPLBoxUnBind(SPLBoxUnBindDto data)
//        {
//            throw new NotImplementedException();
//        }

//        public Task<SPLProcessResultDto> SPLGetBoxData(string BoxSN, string UID, string StationCode)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<SPLProcessResultDto> SPLLogin(string UserName, string Password)
//        {
//            string code = "000";
//            string message = "";
//            object data = null;

//            try
//            {
//                if (UserName == "" || UserName == null || Password == "" || Password == null)
//                {
//                    code = "101";
//                    message = "用户名或密码不能为空";
//                }
//                else
//                {
//                    var vUserList = (await _userRepository.GetUserInfo(UserName));
//                    if (vUserList != null)
//                    {
//                        if (vUserList.Password != Password)
//                        {
//                            code = "102";
//                            message = "密码错误";
//                        }
//                        else
//                        {
//                            data = vUserList;
//                        }
//                    }
//                    else
//                    {
//                        code = "103";
//                        message = "输入的用户名不存在";
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                code = "999";
//                message = ex.Message;
//                // FileTxtHelper.WriteLogTxt(message + "\n", "SPLLogin", "");
//            }
//            return new SPLProcessResultDto { Message = message, Code = code, Data = data, Success = true };
//        }
//    }
//}
