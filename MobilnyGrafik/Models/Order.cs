using System;
namespace MobilnyGrafik.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public Service Service { get; set; }

        public Animal Animal { get; set; }

        public Status Status { get; set; }

    }
}
