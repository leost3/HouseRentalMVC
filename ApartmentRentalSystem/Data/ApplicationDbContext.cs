using System;
using System.Collections.Generic;
using System.Text;
using ApartmentRentalSystem.Models.Apartment;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApartmentRentalSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Apartment> Apartments { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}
