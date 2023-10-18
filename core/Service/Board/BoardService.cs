namespace core.Service
{
    public class BoardService : IBoardService
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public BoardService(IHttpServicesUnAuthorized unAuthorized)
        {
            _unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<BoardAgentsModel>> GetBoardAgents()
        {
            var ret = new List<BoardAgentsModel>();
            Random random = new Random();
            for (int i = 10; i <= 30; i++)
            {
                ret.Add(new BoardAgentsModel
                {
                    AgentsId = i,
                    Name = $"Agente {i}",
                    ProfilePhoto = "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8cmFuZG9tJTIwcGVvcGxlfGVufDB8fDB8fHww&auto=format&fit=crop&w=700&q=60",
                    AgentStatus = "Activo",
                    Quota = random.Next(30, 50),
                    Reached = i,
                    Ranting = random.Next(1, 6),
                    Sold = i * 10,
                    Charged = i*3,
                    Country = "Venezuela"

            });
            }
            for (int i = 1; i <= 10; i++)
            {
                ret.Add(new BoardAgentsModel
                {
                    AgentsId = i,
                    Name = $"Agente {i}",
                    ProfilePhoto = "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8cmFuZG9tJTIwcGVvcGxlfGVufDB8fDB8fHww&auto=format&fit=crop&w=700&q=60",
                    AgentStatus = "Activo",
                    Quota = random.Next(30, 50),
                    Reached = i,
                    Ranting = random.Next(1, 6),
                    Sold = i * 10,
                    Charged = i * 3,
                    Country = "United States"

                });
            }

            return ret.AsQueryable();
        }

        public async Task<ConsultaVentasGeneralModel> GetSales(int year,int month) 
        {
            var  x= await _unAuthorized.GetUnAuthorizedAsync<ConsultaVentasGeneralResponse>("api/v1/Certificados/ConsultaVentasCertificados?anio="+ year + "&mes="+ month);
            return x.Content;
        }
    }
}
