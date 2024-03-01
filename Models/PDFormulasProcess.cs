namespace SPL.Models
{
    public class PDFormulasProcess
    {
        public Guid id { get; set; }
        public int SN { get; set; }
        public string ProductCode { get; set; }
        public string DeviceName { get; set; }
        public string StationCode { get; set; }
        public string isOpen { get; set; }
        public string TransTime { get; set; }
        public string UID { get; set; }
    }
}
