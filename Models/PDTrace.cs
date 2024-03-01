namespace SPL.Models
{
    public class PDTrace
    {
        public Guid Id { get; set; }
        public string StationCode { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string ProductCode { get; set; }
        public string LineCode { get; set; }
        public int BoxIndex { get; set; }
        public string ProductSN { get; set; }
        public string PResult { get; set; }
        public string StatusCode { get; set; }
        public string Remark { get; set; }
        public string TransTime { get; set; }
        public string UID { get; set; }
        public DateTime SysTime { get; set; }

    }
}
