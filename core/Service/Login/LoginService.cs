namespace core.Service
{
    public class LoginService : ILogin
    {
        public async Task<LoginAuthModel> Login(LoginModel model)
        {
            return new LoginAuthModel();
        }
    }
}
