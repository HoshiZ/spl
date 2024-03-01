namespace SPL.Models.Database
{
    public class Device
    {
        public Guid? Id { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public string? DeviceId { get; set; }
        public string? DeviceName { get; set; }
        public string? StationCode { get; set; }
        public string? DeviceType { get; set; }
        public string? LineCode { get; set; }

        
        public IEnumerable<Device> GetSeed()
        {
            var seedList = new List<Device>();
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "YCZY_1", DeviceName = "一次注液机1", StationCode = "OP1", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "YCZY_2", DeviceName = "一次注液机2", StationCode = "OP1", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "YC_1", DeviceName = "预充机1", StationCode = "OP2", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "YC_2", DeviceName = "预充机2", StationCode = "OP2", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "GWJR_Stacker_1", DeviceName = "高温浸润堆垛机1", StationCode = "OP3", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "GWJR_Stacker_2", DeviceName = "高温浸润堆垛机2", StationCode = "OP3", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "CD_1", DeviceName = "充电机1", StationCode = "OP4", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "CD_2", DeviceName = "充电机2", StationCode = "OP4", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "GWLH_1", DeviceName = "高温老化机1", StationCode = "OP5", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "GWLH_2", DeviceName = "高温老化机2", StationCode = "OP5", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "GWLH_3", DeviceName = "高温老化机3", StationCode = "OP5", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "GWLH_4", DeviceName = "高温老化机4", StationCode = "OP5", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "JW_1", DeviceName = "降温机1", StationCode = "OP6", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "JW_2", DeviceName = "降温机2", StationCode = "OP6", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "JW_3", DeviceName = "降温机3", StationCode = "OP6", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "JW_4", DeviceName = "降温机4", StationCode = "OP6", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "ZFDCF1_Stacker_1", DeviceName = "自放电存放1堆垛机1", StationCode = "OP7", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "ZFDCF1_Stacker_2", DeviceName = "自放电存放1堆垛机2", StationCode = "OP7", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "OCV1_1", DeviceName = "OCV1机1", StationCode = "OP8", LineCode = "L05" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "OCV2_2", DeviceName = "OCV1机2", StationCode = "OP8", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "CPK_Stacker_1", DeviceName = "成品库堆垛机1", StationCode = "OP9", LineCode = "L06" });
            seedList.Add(new Device { Id = Guid.NewGuid(), CreationTime = DateTime.Now, LastModificationTime = DateTime.Now, DeviceId = "CPK_Stacker_2", DeviceName = "成品库堆垛机2", StationCode = "OP9", LineCode = "L06" });


            return seedList;
        }
    }
}
