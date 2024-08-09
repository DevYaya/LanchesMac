namespace LanchesMac.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Snack> Snacks { get; set; }
    }
}
