using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DAO.MapConfigs
{
    class ClientMapConfig : EntityTypeConfiguration<ClientDTO>
    {
        public ClientMapConfig()
        {
            this.ToTable("CLIENT");

            this.Property(c => c.Name)
                .IsFixedLength()
                .HasMaxLength(14);

            this.Property(c => c.DataNascimento)
                .IsRequired() //este is required é opcional pois a convenção
                              //padrão do EF já é tornar uma data obrigatória
                .HasColumnType("date");

            this.Property(c => c.Email)
                .HasMaxLength(60);

            this.HasIndex(c => c.Email)
                .IsUnique();

            this.Property(c => c.Senha)
                .HasMaxLength(30);
        }
    }
}
