using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastucture.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastucture.Data
{
    public class StoreContext : DbContext
    {
         
        public StoreContext(DbContextOptions option)
        :base(option)
        {
            
        }
        
        public DbSet<Product> Products { get; set; }
        
    }
}