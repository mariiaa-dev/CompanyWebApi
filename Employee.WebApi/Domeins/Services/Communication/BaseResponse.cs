namespace CompanyWebApi.Domeins.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Succsess { get; protected set; }
        public string Message { get; protected set; }

        public BaseResponse(bool succsess, string message)
        {
            Succsess = succsess;
            Message = message;
        }
    }
}
