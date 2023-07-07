namespace core.Service
{
    public interface ILogin
    {
        Task<LoginAuthModel> Login(LoginModel model);
    }
}
