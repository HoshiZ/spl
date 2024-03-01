namespace SPL.Models
{
    public class PDStation
    {
        public Guid Id { get; set; }
        public string StationCode { get; set; }
        public string IsOut { get; set; }
        public string IsIn { get; set; }
        public string IsInspection { get; set; }
        public string Name { get; set; }
        public DateTime TransTime { get; set; }
        public string UID { get; set; }
        public string isNGIntercept { get; set; }
        public string BoxType { get; set; }
        public string OverCheck { get; set; }
        public string Gear { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
