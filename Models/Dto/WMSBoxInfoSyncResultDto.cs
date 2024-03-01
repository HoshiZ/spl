namespace SPL.Models.ResultDto
{
    public class WMSBoxInfoSyncResultDto
    {
        public string Code { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        //public object Data { get; set; }
        public string ProductCode { get; set; }
        public string StationCode { get; set; }
        public string StartInTime { get; set; }
    }
}
