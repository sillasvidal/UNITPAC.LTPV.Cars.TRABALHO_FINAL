using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNITPAC.LTPV.DominioCars.CarsRoot;

namespace UNITPAC.LTPV.Infra.Context
{
    public class LTPVContext : DbContext
    {
        public LTPVContext() : base(ConfigurationManager.ConnectionStrings["StrConexao"].ConnectionString)
        {
    
        }

        public DbSet<Carro> Carros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>().ToTable("Carros");

            modelBuilder.Entity<Carro>().HasKey(pk => pk.ID);

            modelBuilder.Entity<Carro>()
                .Property(p => p.ID)
                .HasColumnName("ID")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired()
                .HasColumnOrder(1);

            modelBuilder.Entity<Carro>()
                .Property(p => p.Modelo)
                .HasColumnName("Modelo")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnOrder(2);

            modelBuilder.Entity<Carro>()
                .Property(p => p.Marca)
                .HasColumnName("Marca")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnOrder(3);

            modelBuilder.Entity<Carro>()
                .Property(p => p.Ano)
                .HasColumnName("Ano")
                .HasColumnType("int")
                .IsRequired()
                .HasColumnOrder(4);

            modelBuilder.Entity<Carro>()
                .Property(p => p.Km)
                .HasColumnName("km")
                .HasColumnType("float")
                .IsRequired()
                .HasColumnOrder(5);

            modelBuilder.Entity<Carro>()
                .Property(p => p.Preco)
                .HasColumnName("Preco")
                .HasColumnType("float")
                .IsRequired()
                .HasColumnOrder(6);

            base.OnModelCreating(modelBuilder);
        }
    }
}
