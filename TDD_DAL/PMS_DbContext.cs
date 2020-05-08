using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TDD_Entities;

namespace TDD_DAL
{
    public class PMS_DbContext : DbContext
    {
        public PMS_DbContext(DbContextOptions<PMS_DbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

    }
}
