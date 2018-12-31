using id4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace id4.DAL
{
    public class EFContext:DbContext
    {
        public EFContext(DbContextOptions<EFContext> options):base(options)
        {

        }
        
        public DbSet<Admin> Admin { get; set; }
    }
}
