using System;
namespace MobilnyGrafik.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AppUser User { get; set; }
        public string UserId { get; set; }
    }
}
