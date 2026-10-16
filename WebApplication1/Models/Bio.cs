namespace WebApplication1.Models
{
    public class Bio
    {
        public Bio(int id, string name, string roleBadge, string historyText, string factOne, string factTwo)
        {
            Id = id;
            Name = name;
            RoleBadge = roleBadge;
            HistoryText = historyText;
            FactOne = factOne;
            FactTwo = factTwo;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleBadge {  get; set; }
        public string HistoryText {  get; set; }
        public string FactOne { get; set; }
        public string FactTwo {  get; set; }
    }
}
