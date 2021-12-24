using Microsoft.EntityFrameworkCore;
using System;

namespace GreenfieldData
{
    public class SubjectDbContext : DbContext 
    {
        public SubjectDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
