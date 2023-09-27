namespace core.Service
{
    public interface ILogin
    {
        Task<ResponseRequestLoginAuthModel> Login(LoginModel model);
    }
}
