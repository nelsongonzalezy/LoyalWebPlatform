namespace core.Service
{
    public class LoginService : ILogin
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public LoginService(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
        public async Task<LoginAuthModel> Login(LoginModel model)
        {
            var y = await _unAuthorized.PostUnAuthorizedAsync<LoginModel, ResponseRequestLoginAuthModel>("api/v1/Auth",model);

            return y.Content.User;
           
        }
    }
}
