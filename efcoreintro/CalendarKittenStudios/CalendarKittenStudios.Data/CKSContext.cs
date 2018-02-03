using CalendarKittenStudios.Domain;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace CalendarKittenStudios.Data
{
    public class CKSContext: DbContext
    {
        public DbSet<Calendar> Calenders { get; set; }
        public DbSet<Kitten> Kittens { get; set; }
        public DbSet<Photographer> Photographers { get; set; }
    }
}
