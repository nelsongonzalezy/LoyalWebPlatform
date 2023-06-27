namespace core.Service
{
    public class BoardAgentsModel
    {
        public int AgentsId { get; set; }
        public string Name { get; set; }
        public string ProfilePhoto { get; set; }
        public string AgentStatus { get; set; }
        public string Country { get; set; }
        public int Quota { get; set; } = 0;
        public int Reached { get; set; }= 0;
        public int Progress => Quota - Reached;
        public int Ranting { get; set; } = 0;
        public decimal Sold { get; set; } = 0;
        public decimal Charged { get; set; } = 0;
    }
}
