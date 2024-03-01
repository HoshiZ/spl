namespace SPL.Models.SPLProcessResult
{
    public class SPLProcessResultDto
    {
        public SPLProcessResultDto() 
        {
            this.Success = true;
            this.Code = "000";
            this.Message = string.Empty;
            this.Data = null;
        }

        public bool Success { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
