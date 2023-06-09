using core.Service;
using Microsoft.AspNetCore.Mvc;

namespace webLoyal.Controllers
{
    public class CertificatesController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<CertificatesDetailModel>();
            model.Add(new CertificatesDetailModel { CertificateCode = 1, TypeOfDocument = "registro", Name = "Registro", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            model.Add(new CertificatesDetailModel { CertificateCode = 2, TypeOfDocument = "SS", Name = "seguro social", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            model.Add(new CertificatesDetailModel { CertificateCode = 3, TypeOfDocument = "NIT", Name = "registro", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            model.Add(new CertificatesDetailModel { CertificateCode = 4, TypeOfDocument = "CI", Name = "cedula", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            model.Add(new CertificatesDetailModel { CertificateCode = 5, TypeOfDocument = "registro", Name = "Registro", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            model.Add(new CertificatesDetailModel { CertificateCode = 6, TypeOfDocument = "registro", Name = "Registro", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            model.Add(new CertificatesDetailModel { CertificateCode = 7, TypeOfDocument = "registro", Name = "Registro", Descripction = "usa registro", RegistrationDate = DateTime.Now, ExpirationDate= DateTime.Now , LogUser="Mail@mail.com" });
            

            return View(model);
        }
    }
}
