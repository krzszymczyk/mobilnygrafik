using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MobilnyGrafik.Models;

namespace MobilnyGrafik.DataAccessLayer
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
