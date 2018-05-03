using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MobilnyGrafik.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int AnimalID { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }


    }
}
