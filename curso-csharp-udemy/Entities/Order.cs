using curso_csharp_udemy.Entities.Enums;

namespace curso_csharp_udemy.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePurchase { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Purchase date: {DatePurchase}, status: {Status}"; 
        }
    }
}
