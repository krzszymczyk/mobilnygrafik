using System;
namespace MobilnyGrafik.Models
{
    public class Order
    {
        public int Id{ get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }
        public Animal Animal { get; set; }
        public int AnimalId { get; set; }
        public Status Status { get; set; }
        public decimal TotalCost { get; set; }

    }
}
