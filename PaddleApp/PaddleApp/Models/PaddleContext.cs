using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PaddleApp.Models
{
    public class PaddleContext : DbContext
    {

        public PaddleContext() : base("PaddleConnection")
        { 

        }
            public DbSet<Paddle> Location { get; set; }
            public DbSet<Court> Court { get; set; }
            public DbSet<Booking> Booking { get; set; }

        
    }
}