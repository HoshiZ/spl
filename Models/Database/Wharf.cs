namespace SPL.Models.Database
{
    public class Wharf
    {
        public Guid? Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public string? IsDeleted { get; set; }
        public string? WharfId { get; set; }
        public string? WharfName { get; set; }
        public string? WharfBlockId { get; set; }
        public string? BoxId { get; set; }
        public string? State { get; set; }
        public string? WharfType { get; set; }
        public string? LineCode { get; set; }

        public IEnumerable<Wharf> GetSeed()
        {
            var seedList = new List<Wharf>();

            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_YCZY_LINE_IN1", WharfName = "五六线一次注液入线口1", WharfBlockId = "10001", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_YCZY_FL1", WharfName = "五六线一次注液分流口1", WharfBlockId = "10004", WharfType = "Wharf-Spit", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_YCZY_STATION_IN1", WharfName = "五线一次注液入站口1", WharfBlockId = "10018", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_YCZY_STATION_OUT1", WharfName = "五线一次注液出站口1", WharfBlockId = "10020", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_YCZY_STATION_IN1", WharfName = "六线一次注液入站口1", WharfBlockId = "10029", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_YCZY_STATION_OUT1", WharfName = "五线一次注液出站口1", WharfBlockId = "10031", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_YC_LINE_IN1", WharfName = "五六线预充入线口1", WharfBlockId = "20001", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_YC_FL1", WharfName = "五六线预充分流口1", WharfBlockId = "20003", WharfType = "Wharf-Spit", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_YC_STATION_IN1", WharfName = "五线预充入站口", WharfBlockId = "20017", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_YC_STATION_OUT1", WharfName = "五线预充出站口", WharfBlockId = "20019", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_YC_STATION_IN1", WharfName = "六线预充入站口", WharfBlockId = "20028", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_YC_STATION_OUT1", WharfName = "六线预充出站口", WharfBlockId = "20030", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_GWJR_IN1", WharfName = "五六线高温浸润入线口1", WharfBlockId = "20044", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_GWJR_CK_IN1", WharfName = "五线高温浸润仓库入库口1", WharfBlockId = "20058", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_GWJR_CK_IN1", WharfName = "六线高温浸润仓库入库口1", WharfBlockId = "20063", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_GWJR_CK_OUT1", WharfName = "五线高温浸润仓库出库口1", WharfBlockId = "30001", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_GWJR_CK_OUT1", WharfName = "六线高温浸润仓库出库口1", WharfBlockId = "30006", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_CD_IN1", WharfName = "五六线充电入线口1", WharfBlockId = "30019", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_CD_FL1", WharfName = "五六线充电分流口1", WharfBlockId = "30026", WharfType = "Wharf-Spit", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_CD_STATION_IN1", WharfName = "五线充电入站口1", WharfBlockId = "30042", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_CD_STATION_OUT1", WharfName = "五线充电出站口1", WharfBlockId = "30044", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_CD_STATION_IN2", WharfName = "五线充电入站口2", WharfBlockId = "30053", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_CD_STATION_OUT2", WharfName = "五线充电出站口2", WharfBlockId = "30055", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_CD_STATION_IN1", WharfName = "六线充电入站口1", WharfBlockId = "30070", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_CD_STATION_OUT1", WharfName = "六线充电出站口1", WharfBlockId = "30072", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_CD_STATION_IN2", WharfName = "六线充电入站口2", WharfBlockId = "30087", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_CD_STATION_OUT2", WharfName = "六线充电出站口2", WharfBlockId = "30089", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_GWLH_FL1", WharfName = "五六线高温老化分流口1", WharfBlockId = "30116", WharfType = "Wharf-Spit", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_GWLH_STATION_IN1", WharfName = "五线高温老化入站口1", WharfBlockId = "30129", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_GWLH_STATION_OUT1", WharfName = "五线高温老化出站口1", WharfBlockId = "30131", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_JW_STATION_IN1", WharfName = "五线降温入站口1", WharfBlockId = "30133", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_JW_STATION_OUT1", WharfName = "五线降温出站口1", WharfBlockId = "30135", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_GWLH_STATION_IN2", WharfName = "五线高温浸润入站口2", WharfBlockId = "30141", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_GWLH_STATION_OUT2", WharfName = "五线高温浸润出站口2", WharfBlockId = "30143", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_JW_STATION_IN2", WharfName = "五线降温入站口2", WharfBlockId = "30145", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_JW_STATION_OUT2", WharfName = "五线降温出站口2", WharfBlockId = "30147", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_GWLH_STATION_IN1", WharfName = "六线高温浸润入站口1", WharfBlockId = "30158", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_GWLH_STATION_OUT1", WharfName = "六线高温浸润出站口1", WharfBlockId = "30160", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_JW_STATION_IN1", WharfName = "六线降温入站口1", WharfBlockId = "30162", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_JW_STATION_OUT1", WharfName = "六线降温出站口1", WharfBlockId = "30164", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_GWLH_STATION_IN2", WharfName = "六线高温浸润入站口2", WharfBlockId = "30175", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_GWLH_STATION_OUT2", WharfName = "六线高温浸润出站口2", WharfBlockId = "30177", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_JW_STATION_IN2", WharfName = "六线降温入站口2", WharfBlockId = "30179", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_JW_STATION_OUT2", WharfName = "六线降温出站口2", WharfBlockId = "30181", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_ZFDCF1_CK_IN1", WharfName = "五线自放电存放1入库口1", WharfBlockId = "30157", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_ZFDCF1_CK_IN1", WharfName = "六线自放电存放1入库口1", WharfBlockId = "30174", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_ZFDCF1_CK_OUT1", WharfName = "五六线自放电存放1出库口1", WharfBlockId = "40001", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05-06_OCV1_IN1", WharfName = "五六线OCV1分流口1", WharfBlockId = "40003", WharfType = "Wharf-Spit", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_OCV1_STATION_IN1", WharfName = "五线OCV1入站口1", WharfBlockId = "40017", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_OCV1_STATION_OUT1", WharfName = "五线OCV1出站口1", WharfBlockId = "40019", WharfType = "Wharf-Out", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_OCV1_STATION_IN1", WharfName = "六线OCV1入站口1", WharfBlockId = "40028", WharfType = "Wharf-In", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_OCV1_STATION_OUT1", WharfName = "六线OCV1出站口1", WharfBlockId = "40030", WharfType = "Wharf-Out", LineCode = "L06" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L05_CPK_CK_IN1", WharfName = "五线成品库入库口1", WharfBlockId = "40023", WharfType = "Wharf-In", LineCode = "L05" });
            seedList.Add(new Wharf { Id = Guid.NewGuid(), WharfId = "L06_CPK_CK_IN1", WharfName = "六线成品库入库口1", WharfBlockId = "40034", WharfType = "Wharf-In", LineCode = "L06" });

            return seedList;
        }
    }
}
