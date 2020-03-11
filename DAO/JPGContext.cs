using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DAO
{
    public class JPGContext: DbContext
    {
        public JPGContext(DbContextOptions<JPGContext> kkk)
        {

        }

       

        public DbSet<EmployeeDTO> Employees { get; set; }
        public DbSet<DrinkDTO> Drinks { get; set; }
        public DbSet<ClientDTO> Clients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Properties()
            //            .Where(c => c.PropertyType == typeof(string))
            //            .Configure(c => c.IsRequired().IsUnicode(false));

            base.OnModelCreating(modelBuilder);
        }


    }
}
