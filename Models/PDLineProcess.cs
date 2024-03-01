namespace SPL.Models
{
    public class PDLineProcess
    {
        public Guid Id { get; set; }
        public int SN { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string ProductCode { get; set; }
        public string StationCode { get; set; }
        public string LineCode { get; set; }
        public string CellType { get; set; }
        public string IsOpen { get; set; }
        public string DisCellType { get; set; }
    }
}
