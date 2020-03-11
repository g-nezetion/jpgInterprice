using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DAO.MapConfigs
{
    class EmployeeMapConfig : EntityTypeConfiguration<EmployeeDTO>
    {
        public EmployeeMapConfig()
        {
            this.ToTable("Employee");

            this.Property(c => c.Nome)
                .HasMaxLength(14);

            this.Property(c => c.CPF)
               .IsFixedLength()
               .HasMaxLength(14);

            this.HasIndex(c => c.CPF).IsUnique();


            this.Property(c => c.Email)
                .HasMaxLength(60);

            this.HasIndex(c => c.Email)
                .IsUnique();

           
        }
    }
}
