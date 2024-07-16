
namespace API.Errors
{
    public class ApiExceptions
    {
        public ApiExceptions(int StatusCode, string Message, string Details)
        {
            this.StatusCode = StatusCode;
            this.Message = Message;
            this.Details = Details;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }

    }
}