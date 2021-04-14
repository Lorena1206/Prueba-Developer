using Microsoft.EntityFrameworkCore;
using Prueba_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Api.Data
{
    public class tickets : DbContext
    {
        public tickets(DbContextOptions<tickets> opcions) : base(opcions)
        { 
        }

        // creacíon dbset
        public DbSet <Informacion> Infomacionitems { get; set; }

    }
        
    
    
    
}
