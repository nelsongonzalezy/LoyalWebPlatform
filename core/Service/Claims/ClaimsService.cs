namespace core.Service
{
    public class ClaimsService : IClaimsServ
    {

       public ClaimsService() { }

        public async Task<IQueryable<ClaimCreateModel>> GetAll()
        {
            //var claims = await HttpServices.GetAuthorizedAsync<List<ClaimListModel>>("api/Claim/GetAll", LoginService.Token);
            var claims = new List<ClaimCreateModel>();
            claims.Add(new ClaimCreateModel { ClaimId = 1, ClaimNumber = "Claim 1", UserName="Jose rafael", UserType="Agente",ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = 50000, ClaimDescription = "Ejemplo de descripcion", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 2, ClaimNumber = "Claim 2", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = 5000, ClaimDescription = "Ejemplo 2", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 3, ClaimNumber = "Claim 3", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue =600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 4, ClaimNumber = "Claim 4", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = 500, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 5, ClaimNumber = "Claim 5", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 6, ClaimNumber = "Claim 6", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 7, ClaimNumber = "Claim 7", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue =600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 8, ClaimNumber = "Claim 8", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Rembolso", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 9, ClaimNumber = "Claim 9", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 10, ClaimNumber = "Claim 10", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 11, ClaimNumber = "Claim 11", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 12, ClaimNumber = "Claim 12", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 13, ClaimNumber = "Claim 13", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Reclamo", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            claims.Add(new ClaimCreateModel { ClaimId = 14, ClaimNumber = "Claim 14", UserName = "Jose rafael", UserType = "Agente", ClaimType = "Carta Aval", ClaimStatus = "Abierto", ClaimValue = 600, ClaimDescription = " Ejemplo 3 ", ClaimDate = DateTime.Now });
            return claims.AsQueryable();
        }
    }
}
