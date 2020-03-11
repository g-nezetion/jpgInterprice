using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DAO.MapConfigs
{
    class DrinkMapConfig : EntityTypeConfiguration<DrinkDTO>
    {
        public DrinkMapConfig()
        {
            this.ToTable("DRINK");

            this.Property(c => c.Name)
                .HasMaxLength(14);

            this.Property(c => c.Description)
                 .HasMaxLength(70);
            //este is required é opcional pois a convenção
            //padrão do EF já é tornar uma data obrigatória
              

          
        }

    }
}
