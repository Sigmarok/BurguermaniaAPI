using BurguermaniaAPI.Models;

namespace BurguermaniaAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Base_Description { get; set; }
        public string Full_Description { get; set; }
        public float Price { get; set; }
        public string Path_Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}