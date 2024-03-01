namespace SPL.Models.Database
{
    public class ConveyerLine
    {
        public Guid? Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public string? LastModifierId { get; set; }
        public string? IsDeleted { get; set; }
        public string? DeleterId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public string? LineEnable { get; set; }
        public string? DealWay { get; set; }
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public string? FromWharfs { get; set; }
        public string? FromWharfsId { get; set; }
        public string? NextWharfs { get; set; }
        public string? NextWharfsId { get; set; }
        public string? TargetWharfs { get; set; }
        public string? TargetWharfsId { get; set; }
        public string? DefaultPath { get; set; }
        public string? LineCodes { get; set; }
        public string? StationCodesNext { get; set; }
        public string? ProductCodes { get; set; }
        public string? BoxState {  get; set; }
        public int? Priority { get; set; }
        public int? NowCache { get; set; }
        public int? MaxCache { get; set; }
         

        public IEnumerable<ConveyerLine> GetSeed()
        {
            var seedList = new List<ConveyerLine>();

            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05-06_YCZY_LINE_IN1___TO___L05-06_YCZY_FL1", LineName = "一次注液五六线入线到分流1", FromWharfsId = "L05-06_YCZY_LINE_IN1", NextWharfsId = "L05-06_YCZY_FL1", LineCodes = "L05" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_YCZY_FL1___TO___L05_YCZY_STATION_IN1", LineName = "一次注液五六分流1去五线入站1", FromWharfsId = "L05-06_YCZY_FL1", NextWharfsId = "L05_YCZY_STATION_IN1", LineCodes = "L05", StationCodesNext = "OP1" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_YCZY_FL1___TO___L06_YCZY_STATION_IN1", LineName = "一次注液五六分流1去六线入站1", FromWharfsId = "L05-06_YCZY_FL1", NextWharfsId = "L06_YCZY_STATION_IN1", LineCodes = "L06", StationCodesNext = "OP1" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_YCZY_STATION_IN1", LineName = "一次注液五线入站1", FromWharfsId = "L05_YCZY_STATION_IN1", NextWharfsId = "L05_YCZY_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP1" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_YCZY_STATION_IN1", LineName = "一次注液六线入站1", FromWharfsId = "L06_YCZY_STATION_IN1", NextWharfsId = "L06_YCZY_STATION_OUT1", LineCodes = "L06", StationCodesNext = "OP1" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_YCZY_STATION_OUT1___TO___L05-06_YC_LINE_IN1", LineName = "一次注液五线出站1到预充五六线入线1", FromWharfsId = "L05_YCZY_STATION_OUT1", NextWharfsId = "L05-06_YC_LINE_IN1", LineCodes = "L05", StationCodesNext = "OP1" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_YCZY_STATION_OUT1___TO___L05-06_YC_LINE_IN1", LineName = "一次注液六线出站1到预充五六线入线1", FromWharfsId = "L06_YCZY_STATION_OUT1", NextWharfsId = "L05-06_YC_LINE_IN1", LineCodes = "L06", StationCodesNext = "OP1" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05-06_YC_LINE_IN1___TO___L05-06_YC_FL1", LineName = "预充五六线入线1去五六线分流1", FromWharfsId = "L05-06_YC_LINE_IN1", NextWharfsId = "L05-06_YC_FL1", LineCodes = "L05", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_YC_FL1___TO___L05_YC_STATION_IN1", LineName = "预充五六线分流1去五线入站1", FromWharfsId = "L05-06_YC_FL1", NextWharfsId = "L05_YC_STATION_IN1", LineCodes = "L05", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_YC_FL1___TO___L06_YC_STATION_IN1", LineName = "预充五六线分流1去六线入站1", FromWharfsId = "L05-06_YC_FL1", NextWharfsId = "L06_YC_STATION_IN1", LineCodes = "L06", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_YC_STATION_IN1", LineName = "预充五线入站1", FromWharfsId = "L05_YC_STATION_IN", NextWharfsId = "L05_YC_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_YC_STATION_IN1", LineName = "预充六线入站1", FromWharfsId = "L06_YC_STATION_IN1", NextWharfsId = "L06_YC_STATION_OUT1", LineCodes = "L06", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_YC_STATION_OUT1___TO___L05-06_GWJR_IN1", LineName = "预充五线出站1到高温浸润五六线入线1", FromWharfsId = "L05_YC_STATION_OUT1", NextWharfsId = "L05-06_GWJR_IN1", LineCodes = "L05", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_YC_STATION_OUT1___TO___L05-06_GWJR_IN1", LineName = "预充六线出站1到高温浸润五六线入线1", FromWharfsId = "L06_YC_STATION_OUT1", NextWharfsId = "L05-06_GWJR_IN1", LineCodes = "L06", StationCodesNext = "OP2" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_GWJR_IN1___TO___L05_GWJR_CK_IN1", LineName = "高温浸润五六线入线1去高温浸润五线入库1", FromWharfsId = "L05-06_GWJR_IN1", NextWharfsId = "L05_GWJR_CK_IN1", LineCodes = "L05", StationCodesNext = "OP3" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_GWJR_IN1___TO___L06_GWJR_CK_IN1", LineName = "高温浸润五六线入线1去高温浸润六线入库1", FromWharfsId = "L05-06_GWJR_IN1", NextWharfsId = "L06_GWJR_CK_IN1", LineCodes = "L06", StationCodesNext = "OP3" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_GWJR_CK_IN1", LineName = "高温浸润五线入库1", FromWharfsId = "L05_GWJR_CK_IN1", NextWharfsId = "L05_GWJR_CK_OUT1", LineCodes = "L05", StationCodesNext = "OP3" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_GWJR_CK_IN1", LineName = "高温浸润六线入库1", FromWharfsId = "L06_GWJR_CK_IN1", NextWharfsId = "L06_GWJR_CK_OUT1", LineCodes = "L06", StationCodesNext = "OP3" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_GWJR_CK_OUT1___TO___L05-06_CD_IN1", LineName = "高温浸润五线出库1去五六线充电入线1", FromWharfsId = "L05_GWJR_CK_OUT1", NextWharfsId = "L05-06_CD_IN1", LineCodes = "L05", StationCodesNext = "OP3" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_GWJR_CK_OUT1___TO___L05-06_CD_IN1", LineName = "高温浸润六线出库1去五六线充电入线1", FromWharfsId = "L06_GWJR_CK_OUT1", NextWharfsId = "L05-06_CD_IN1", LineCodes = "L06", StationCodesNext = "OP3" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05-06_CD_IN1___TO___L05-06_CD_FL1", LineName = "充电五六线入线去五六线分流1", FromWharfsId = "L05-06_CD_IN1", NextWharfsId = "L05-06_CD_FL1", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_CD_FL1___TO___L05_CD_STATION_IN1", LineName = "充电五六线分流1去五线入站1", FromWharfsId = "L05-06_CD_FL1", NextWharfsId = "L05_CD_STATION_IN1", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_CD_FL1___TO___L05_CD_STATION_IN2", LineName = "充电五六线分流1去五线入站2", FromWharfsId = "L05-06_CD_FL1", NextWharfsId = "L05_CD_STATION_IN2", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_CD_FL1___TO___L06_CD_STATION_IN1", LineName = "充电五六线分流1去六线入站1", FromWharfsId = "L05-06_CD_FL1", NextWharfsId = "L06_CD_STATION_IN1", LineCodes = "L06", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_CD_FL1___TO___L06_CD_STATION_IN2", LineName = "充电五六线分流1去六线入站2", FromWharfsId = "L05-06_CD_FL1", NextWharfsId = "L06_CD_STATION_IN2", LineCodes = "L06", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_CD_STATION_IN1", LineName = "充电五线入站1", FromWharfsId = "L05_CD_STATION_IN1", NextWharfsId = "L05_CD_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_CD_STATION_IN2", LineName = "充电五线入站2", FromWharfsId = "L05_CD_STATION_IN2", NextWharfsId = "L05_CD_STATION_OUT2", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_CD_STATION_IN1", LineName = "充电六线入站1", FromWharfsId = "L06_CD_STATION_IN1", NextWharfsId = "L06_CD_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_CD_STATION_IN2", LineName = "充电六线入站2", FromWharfsId = "L06_CD_STATION_IN2", NextWharfsId = "L06_CD_STATION_OUT2", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_CD_STATION_OUT1___TO___L05-06_GWLH_FL1", LineName = "充电五线出站1去五六线高温老化分流1", FromWharfsId = "L05_CD_STATION_OUT1", NextWharfsId = "L05-06_GWLH_FL1", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_CD_STATION_OUT2___TO___L05-06_GWLH_FL1", LineName = "充电五线出站2去五六线高温老化分流1", FromWharfsId = "L05_CD_STATION_OUT2", NextWharfsId = "L05-06_GWLH_FL1", LineCodes = "L05", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_CD_STATION_OUT1___TO___L05-06_GWLH_FL1", LineName = "充电六线出站1去五六线高温老化分流1", FromWharfsId = "L06_CD_STATION_OUT1", NextWharfsId = "L05-06_GWLH_FL1", LineCodes = "L06", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_CD_STATION_OUT2___TO___L05-06_GWLH_FL1", LineName = "充电六线出站2去五六线高温老化分流1", FromWharfsId = "L06_CD_STATION_OUT2", NextWharfsId = "L05-06_GWLH_FL1", LineCodes = "L06", StationCodesNext = "OP4" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_GWLH_FL1___TO___L05_GWLH_STATION_IN1", LineName = "高温老化五六线去五线入站1", FromWharfsId = "L05-06_GWLH_FL1", NextWharfsId = "L05_GWLH_STATION_IN1", LineCodes = "L05", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_GWLH_FL1___TO___L05_GWLH_STATION_IN2", LineName = "高温老化五六线去五线入站2", FromWharfsId = "L05-06_GWLH_FL1", NextWharfsId = "L05_GWLH_STATION_IN2", LineCodes = "L05", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_GWLH_FL1___TO___L06_GWLH_STATION_IN1", LineName = "高温老化五六线去六线入站1", FromWharfsId = "L05-06_GWLH_FL1", NextWharfsId = "L06_GWLH_STATION_IN1", LineCodes = "L06", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_GWLH_FL1___TO___L06_GWLH_STATION_IN2", LineName = "高温老化五六线去六线入站2", FromWharfsId = "L05-06_GWLH_FL1", NextWharfsId = "L06_GWLH_STATION_IN2", LineCodes = "L06", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_GWLH_STATION_IN1", LineName = "高温老化五线入站1", FromWharfsId = "L05_GWLH_STATION_IN1", NextWharfsId = "L05_GWLH_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_GWLH_STATION_IN2", LineName = "高温老化五线入站2", FromWharfsId = "L05_GWLH_STATION_IN2", NextWharfsId = "L05_GWLH_STATION_OUT2", LineCodes = "L05", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_GWLH_STATION_IN1", LineName = "高温老化六线入站1", FromWharfsId = "L06_GWLH_STATION_IN1", NextWharfsId = "L06_GWLH_STATION_OUT1", LineCodes = "L06", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_GWLH_STATION_IN2", LineName = "高温老化六线入站2", FromWharfsId = "L06_GWLH_STATION_IN2", NextWharfsId = "L06_GWLH_STATION_OUT2", LineCodes = "L06", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_GWLH_STATION_OUT1___TO___L05_JW_STATION_IN1", LineName = "高温老化五线出站1去降温五线入站1", FromWharfsId = "L05_GWLH_STATION_OUT1", NextWharfsId = "L05_JW_STATION_IN1", LineCodes = "L05", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_GWLH_STATION_OUT2___TO___L05_JW_STATION_IN2", LineName = "高温老化五线出站2去降温五线入站2", FromWharfsId = "L05_GWLH_STATION_OUT2", NextWharfsId = "L05_JW_STATION_IN2", LineCodes = "L05", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_GWLH_STATION_OUT1___TO___L06_JW_STATION_IN1", LineName = "高温老化六线出站1去降温六线入站1", FromWharfsId = "L06_GWLH_STATION_OUT1", NextWharfsId = "L06_JW_STATION_IN1", LineCodes = "L06", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_GWLH_STATION_OUT2___TO___L06_JW_STATION_IN2", LineName = "高温老化六线出站2去降温六线入站2", FromWharfsId = "L06_GWLH_STATION_OUT2", NextWharfsId = "L06_JW_STATION_IN2", LineCodes = "L06", StationCodesNext = "OP5" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_JW_STATION_IN1", LineName = "降温五线入站1", FromWharfsId = "L05_JW_STATION_IN1", NextWharfsId = "L05_JW_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_JW_STATION_IN2", LineName = "降温五线入站2", FromWharfsId = "L05_JW_STATION_IN2", NextWharfsId = "L05_JW_STATION_OUT2", LineCodes = "L05", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_JW_STATION_IN1", LineName = "降温五线入站1", FromWharfsId = "L06_JW_STATION_IN1", NextWharfsId = "L06_JW_STATION_OUT1", LineCodes = "L06", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_JW_STATION_IN2", LineName = "降温五线入站2", FromWharfsId = "L06_JW_STATION_IN2", NextWharfsId = "L06_JW_STATION_OUT2", LineCodes = "L06", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_JW_STATION_OUT1___TO___L05_ZFDCF1_CK_IN1", LineName = "降温五线出站1去自放电存放五线入库1", FromWharfsId = "L05_JW_STATION_OUT1", NextWharfsId = "L05_ZFDCF1_CK_IN1", LineCodes = "L05", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_JW_STATION_OUT2___TO___L05_ZFDCF1_CK_IN1", LineName = "降温五线出站2去自放电存放五线入库1", FromWharfsId = "L05_JW_STATION_OUT2", NextWharfsId = "L05_ZFDCF1_CK_IN1", LineCodes = "L05", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_JW_STATION_OUT1___TO___L06_ZFDCF1_CK_IN1", LineName = "降温六线出站1去自放电存放六线入库1", FromWharfsId = "L06_JW_STATION_OUT1", NextWharfsId = "L06_ZFDCF1_CK_IN1", LineCodes = "L06", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_JW_STATION_OUT2___TO___L06_ZFDCF1_CK_IN1", LineName = "降温六线出站2去自放电存放六线入库1", FromWharfsId = "L06_JW_STATION_OUT2", NextWharfsId = "L06_ZFDCF1_CK_IN1", LineCodes = "L06", StationCodesNext = "OP6" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_ZFDCF1_CK_IN1", LineName = "自放电存放1五线入库1", FromWharfsId = "L05_ZFDCF1_CK_IN1", NextWharfsId = "L05-06_ZFDCF1_CK_OUT1", LineCodes = "L05", StationCodesNext = "OP7" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_ZFDCF1_CK_IN1", LineName = "自放电存放1六线入库1", FromWharfsId = "L06_ZFDCF1_CK_IN1", NextWharfsId = "L05-06_ZFDCF1_CK_OUT1", LineCodes = "L06", StationCodesNext = "OP7" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05-06_ZFDCF1_CK_OUT1___TO___L05-06_OCV1_FL1", LineName = "自放电存放1五六线出库去OCV1五六线分流1", FromWharfsId = "L05-06_ZFDCF1_CK_OUT1", NextWharfsId = "L05-06_OCV1_FL1", LineCodes = "L05", StationCodesNext = "OP7" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_OCV1_FL1___TO___L05_OCV1_STATION_IN1", LineName = "OCV1五六线分流1去0CV1五线进站1", FromWharfsId = "L05-06_OCV1_FL1", NextWharfsId = "L05_OCV1_STATION_IN1", LineCodes = "L05", StationCodesNext = "OP8" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "AllotAlley", LineId = "L05-06_OCV1_FL1___TO___L06_OCV1_STATION_IN1", LineName = "OCV1五六线分流1去0CV1六线进站1", FromWharfsId = "L05-06_OCV1_FL1", NextWharfsId = "L06_OCV1_STATION_IN1", LineCodes = "L06", StationCodesNext = "OP8" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_OCV1_STATION_IN1", LineName = "0CV1五线进站1", FromWharfsId = "L05_OCV1_STATION_IN1", NextWharfsId = "L05_OCV1_STATION_OUT1", LineCodes = "L05", StationCodesNext = "OP8" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_OCV1_STATION_IN1", LineName = "0CV1六线进站1", FromWharfsId = "L06_OCV1_STATION_IN1", NextWharfsId = "L06_OCV1_STATION_OUT1", LineCodes = "L06", StationCodesNext = "OP8" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L05_OCV1_STATION_OUT1___TO___L05_CPK_CK_IN1", LineName = "0CV1五线出站1去成品库五线入站1", FromWharfsId = "L05_OCV1_STATION_OUT1", NextWharfsId = "L05_CPK_CK_IN1", LineCodes = "L05", StationCodesNext = "OP8" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "OUT", LineId = "L06_OCV1_STATION_OUT1___TO___L06_CPK_CK_IN1", LineName = "0CV1六线出站1去成品库六线入站1", FromWharfsId = "L06_OCV1_STATION_OUT1", NextWharfsId = "L06_CPK_CK_IN1", LineCodes = "L06", StationCodesNext = "OP8" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L05_CPK_CK_IN1", LineName = "成品库五线入站1", FromWharfsId = "L05_CPK_CK_IN1", NextWharfsId = "NULL", LineCodes = "L05", StationCodesNext = "OP9" });
            seedList.Add(new ConveyerLine { Id = Guid.NewGuid(), DealWay = "IN", LineId = "L06_CPK_CK_IN1", LineName = "成品库六线入站1", FromWharfsId = "L06_CPK_CK_IN1", NextWharfsId = "NULL", LineCodes = "L06", StationCodesNext = "OP9" });

            return seedList;
        }
    }
}
