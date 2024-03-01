namespace SPL.Models.Database
{
    public class Station
    {
        public Guid? Id { get; set; }
        public string? StationId { get; set; }
        public string? StationName { get; set; }
        public int? StationBlockId { get; set; }
        public string? StationInWharf { get; set; }
        public string? StationOutWharf { get; set; }
        public string? LineCode { get; set; }
        public int? StationTime { get; set; }


        public IEnumerable<Station> GetSeed()
        {
            var seedList = new List<Station>();
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 10019, StationId = "YCZY_STATION1", StationName = "一次注液站点1", StationInWharf = "L05_YCZY_STATION_IN1", StationOutWharf = "L05_YCZY_STATION_OUT1", LineCode = "L05",StationTime = 20});
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 10030, StationId = "YCZY_STATION2", StationName = "一次注液站点2", StationInWharf = "L06_YCZY_STATION_IN2", StationOutWharf = "L06_YCZY_STATION_OUT1", LineCode = "L06", StationTime = 20});
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 20018, StationId = "YC_STATION1", StationName = "预充站点1", StationInWharf = "L05_YC_STATION_IN1", StationOutWharf = "L05_YC_STATION_OUT1", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 20029, StationId = "YC_STATION2", StationName = "预充站点2", StationInWharf = "L06_YC_STATION_IN2", StationOutWharf = "L06_YC_STATION_OUT1", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 20058, StationId = "GWJR_CK_IN1", StationName = "高温浸润站点1", StationInWharf = "L05_GWJR_CK_IN1", StationOutWharf = "L05_GWJR_CK_OUT1", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 20063, StationId = "GWJR_CK_IN2", StationName = "高温浸润站点2", StationInWharf = "L06_GWJR_CK_IN1", StationOutWharf = "L06_GWJR_CK_OUT1", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30043, StationId = "CD_STATION_IN1", StationName = "充电站点1", StationInWharf = "L05_CD_STATION_IN1", StationOutWharf = "L05_CD_STATION_OUT1", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30054, StationId = "CD_STATION_IN2", StationName = "充电站点2", StationInWharf = "L05_CD_STATION_IN2", StationOutWharf = "L05_CD_STATION_OUT2", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30071, StationId = "CD_STATION_IN3", StationName = "充电站点3", StationInWharf = "L06_CD_STATION_IN1", StationOutWharf = "L06_CD_STATION_OUT1", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30088, StationId = "CD_STATION_IN4", StationName = "充电站点4", StationInWharf = "L06_CD_STATION_IN2", StationOutWharf = "L06_CD_STATION_OUT2", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30130, StationId = "GWLH_STATION_IN1", StationName = "高温老化站点1", StationInWharf = "L05_GWLH_STATION_IN1", StationOutWharf = "L05_GWLH_STATION_OUT1", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30142, StationId = "GWLH_STATION_IN2", StationName = "高温老化站点2", StationInWharf = "L05_GWLH_STATION_IN2", StationOutWharf = "L05_GWLH_STATION_OUT2", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30159, StationId = "GWLH_STATION_IN3", StationName = "高温老化站点3", StationInWharf = "L06_GWLH_STATION_IN1", StationOutWharf = "L06_GWLH_STATION_OUT1", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30176, StationId = "GWLH_STATION_IN4", StationName = "高温老化站点4", StationInWharf = "L06_GWLH_STATION_IN2", StationOutWharf = "L06_GWLH_STATION_OUT2", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30134, StationId = "JW_STATION_IN1", StationName = "降温站点1", StationInWharf = "L05_JW_STATION_IN1", StationOutWharf = "L05_JW_STATION_OUT1", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30146, StationId = "JW_STATION_IN2", StationName = "降温站点2", StationInWharf = "L05_JW_STATION_IN2", StationOutWharf = "L05_JW_STATION_OUT2", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30163, StationId = "JW_STATION_IN3", StationName = "降温站点3", StationInWharf = "L06_JW_STATION_IN1", StationOutWharf = "L06_JW_STATION_OUT1", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 30180, StationId = "JW_STATION_IN4", StationName = "降温站点4", StationInWharf = "L06_JW_STATION_IN2", StationOutWharf = "L06_JW_STATION_OUT2", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 40018, StationId = "OCV1_STATION_IN1", StationName = "OCV1站点1", StationInWharf = "L05_OCV1_STATION_IN1", StationOutWharf = "L05_OCV1_STATION_OUT1", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 40029, StationId = "OCV1_STATION_IN2", StationName = "OCV1站点2", StationInWharf = "L06_OCV1_STATION_IN1", StationOutWharf = "L06_OCV1_STATION_OUT1", LineCode = "L06", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 40023, StationId = "CPK_CK_IN1", StationName = "成品库站点1", StationInWharf = "L05_CPK_CK_IN1", StationOutWharf = "NULL", LineCode = "L05", StationTime = 20 });
            seedList.Add(new Station { Id = Guid.NewGuid(), StationBlockId = 40034, StationId = "CPK_CK_IN2", StationName = "成品库站点2", StationInWharf = "L06_CPK_CK_IN1", StationOutWharf = "NULL", LineCode = "L06", StationTime = 20 });

            return seedList;
        }
    }
}
