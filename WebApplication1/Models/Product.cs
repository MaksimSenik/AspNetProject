namespace WebApplication1.Models
{
    public class Product
    {
        public Product(int id, string name, string agentnName, string descript)
        {
            Id = id;
            Name = name;
            AgentName = agentnName;
            Descript = descript;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string AgentName { get; set; }
        public string Descript {  get; set; }
    }
}
