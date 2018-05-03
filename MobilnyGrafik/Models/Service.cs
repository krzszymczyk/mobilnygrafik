using System;
namespace MobilnyGrafik.Models
{
    public class Service
    {
        public int ServiceID { get; set; }

        public string ServiceName { get; set; }

        public TimeSpan Length { get; set; }

        public decimal Price { get; set; }
    }
}
