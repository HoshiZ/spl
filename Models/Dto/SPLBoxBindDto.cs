namespace SPL.Models.Dto
{
    public class SPLBoxBindDto
    {
        public string LineCode { get; set; }
        public string StationCode { get; set; }
        public string DeviceCode { get; set; }
        public string BoxSN { get; set; }
        public List<ObjProductSN> LstProductSN { get; set;}
        public string UID { get; set; }
        public string TransTime { get; set; }

    }
}
