using System;
namespace MobilnyGrafik.Models
{
    public class Service
    {
        public int Id { get; set; }

        public string ServiceName { get; set; }

        public ServiceType ServiceType { get; set; }

        public TimeSpan Length { get; set; }

        public decimal Price { get; set; }
    }
}
