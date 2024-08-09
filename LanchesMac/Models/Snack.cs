namespace LanchesMac.Models
{
    public class Snack
    {
        public int SnackId { get; set; }
        public string Name { get; set; }
        public string DescriptionShort { get; set; }
        public string DescriptionDetail { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsSnackFavorite { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
