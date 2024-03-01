using System.ComponentModel.DataAnnotations;

namespace SPL.Models.Dto
{
    public class SPLBoxInDto
    {
        [Required(ErrorMessage = "参数不能为空")]
        public string LineCode { get; set; }

        public string StationCode { get; set; }

        public string DeviceCode { get; set; }

        public string BoxSN { get; set; }

        public List<ObjProductSN> LstProductSN {  get; set; }
        public string UID { get; set; }
        public string TransTime { get; set; }

    }
}
