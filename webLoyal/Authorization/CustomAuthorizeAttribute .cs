namespace webLoyal.Authorization
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAuthorizeAttribute : TypeFilterAttribute
    {
        public CustomAuthorizeAttribute() : base(typeof(CustomAuthorizeFilter)) { }
    }

    public class CustomAuthorizeFilter : IAuthorizationFilter
    {
        public CustomAuthorizeFilter()
        {
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();

            //Si esta como anonimo, no requiere que tengo un token de sesion, 
            //esto lo puedes usar en metodos como login, recuperacion de contraseña, teniendo ciertas consideraciones de seguridad
            if (allowAnonymous) return;

            bool isGranted = context.HttpContext.Session.Get("Token") != null;

            //Si el valor es falso redirecciona al Login, puedes agregar un mensaje
            if (!isGranted)
                context.Result = new RedirectToActionResult("Index", "Auth", new { error = "Debe iniciar sesión" });
        }
    }
}
