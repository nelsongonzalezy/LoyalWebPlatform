using core.Service.Login.Model;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace core.Service
{
    public class LoginService : ILogin
    {
        public async Task<LoginAuthModel> Login(LoginModel model)
        {
            HttpResponseMessage respuesta;

            using (var httpClient = new HttpClient())
            {
				var url = "http://apirestloyal-env.us-east-1.elasticbeanstalk.com/api/v1/Auth";
				respuesta = await httpClient.PostAsJsonAsync(url, model);
			}                

            if (respuesta.IsSuccessStatusCode)
            {
                var responseAuth = await respuesta.Content.ReadFromJsonAsync<ResponseAuthApi>();
                var loginAuthModel = new LoginAuthModel
                {
                    AddressEmail = responseAuth.Content.User.DireccionEmail,
                    CodeProfile = responseAuth.Content.User.CodigoPerfil,
                    CodeStateUser = responseAuth.Content.User.CodigoEstadoUsuario.ToString(),
                    FullNameUser = responseAuth.Content.User.NombreCompletoUsuario,
                    IndicatorChangePassword = Convert.ToInt32(responseAuth.Content.User.IndicadorCambioPassword), 
                    IndicatorMailVerified = Convert.ToInt32(responseAuth.Content.User.IndicadorCorreoVerificado),
                    IndicatorViewAgents = Convert.ToInt32(responseAuth.Content.User.IndicadorVistaAgentes),                 
                    NamePage = responseAuth.Content.User.NombrePagina,
                    NameProfile = responseAuth.Content.User.NombrePerfil,
                    UserCode = responseAuth.Content.User.CodigoUsuario                               
				};
				return loginAuthModel;
			}
            else
            {
                throw new Exception("Autenticación fallida");
			}
		}
    }
}
