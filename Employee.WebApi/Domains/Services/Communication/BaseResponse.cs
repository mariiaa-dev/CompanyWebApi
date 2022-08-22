namespace CompanyWebApi.Domains.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Success { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool succsess, string message)
        {
            Success = succsess;
            Message = message;
        }
    }
}
