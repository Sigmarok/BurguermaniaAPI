using BurguermaniaAPI.Models;

namespace BurguermaniaAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public float Value { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
        public List<UserOrder> UserOrders { get; set; }
    }
}