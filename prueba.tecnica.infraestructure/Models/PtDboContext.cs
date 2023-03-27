using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace prueba.tecnica.infraestructure.Models
{
    public partial class PtDboContext : DbContext
    {

        private string _stringConnection;
        public PtDboContext(string stringConn)
        {
            _stringConnection = stringConn;
        }


        public PtDboContext(DbContextOptions<PtDboContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCliente> TblClientes { get; set; } = null!;
        public virtual DbSet<TblEstadoCivil> TblEstadoCivils { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(this._stringConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e=> e.nroDocumento);

                entity.ToTable("tbl_cliente");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.nroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nroDocumento");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnType("numeric(1, 0)")
                    .HasColumnName("idEstadoCivil");

                entity.Property(e => e.IdTipoDoc)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("idTipoDoc");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.Valor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("valor");
            });

            modelBuilder.Entity<TblEstadoCivil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_estado_civil");

                entity.Property(e => e.Activo).HasColumnType("numeric(1, 0)");

                entity.Property(e => e.CodEstadoCivil)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("codEstadoCivil");

                entity.Property(e => e.DescEstadoCivil)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descEstadoCivil");

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("idEstadoCivil");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
