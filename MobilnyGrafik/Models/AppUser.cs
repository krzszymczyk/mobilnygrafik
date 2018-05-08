using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MobilnyGrafik.Models
{
    public class AppUser:IdentityUser
    {
        public AppUser()
        {
                Animals = new List<Animal>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  ICollection<Animal> Animals { get; set; }


    }
}
