using System.Security.Claims;

namespace core.Service
{
    public class ClaimsService : IClaimsServ
    {

       public ClaimsService() { }

        public async Task<IQueryable<ClaimCreateModel>> GetAll()
        {
            //var claims = await HttpServices.GetAuthorizedAsync<List<ClaimListModel>>("api/Claim/GetAll", LoginService.Token);
            var claims = new List<ClaimCreateModel>();
            claims.Add(new ClaimCreateModel { ClaimId = 1, ClaimNumber = "Claim 1", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = "2.500,00$", ClaimDescription = "Ejemplo de descripcion", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 2, ClaimNumber = "Claim 2", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = "5.000,00$", ClaimDescription = "Ejemplo 2", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 3, ClaimNumber = "Claim 3", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 4, ClaimNumber = "Claim 4", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 5, ClaimNumber = "Claim 5", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 6, ClaimNumber = "Claim 6", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 7, ClaimNumber = "Claim 7", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 8, ClaimNumber = "Claim 8", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 9, ClaimNumber = "Claim 9", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 10, ClaimNumber = "Claim 10", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 11, ClaimNumber = "Claim 11", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 12, ClaimNumber = "Claim 12", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 13, ClaimNumber = "Claim 13", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 14, ClaimNumber = "Claim 14", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = "600,00$", ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            return claims.AsQueryable();
        }
    }
}
