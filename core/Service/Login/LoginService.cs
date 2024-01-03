using core.Service.Login.Model;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace core.Service
{
    public class LoginService : ILogin
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public LoginService(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }

        public async Task<ResponseRequestLoginAuthModel> Login(LoginModel model)
        {
            var loginAuthModel = await _unAuthorized.PostUnAuthorizedAsync<LoginModel, ResponseRequestLoginAuthModel>("api/v1/Auth",model);

            return loginAuthModel;
           

        }
    }
}
