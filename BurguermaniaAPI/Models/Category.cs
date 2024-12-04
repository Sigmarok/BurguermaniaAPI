using BurguermaniaAPI.Models;

namespace BurguermaniaAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path_Image { get; set; }

        public List<Product> Products { get; set; }
    }
    
}