using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace API_Dimag.Models
{
    public partial class DBDimagContext : DbContext
    {
        public DBDimagContext()
        {
        }

        public DBDimagContext(DbContextOptions<DBDimagContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blusas> Blusas { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Colores> Colores { get; set; } = null!;
        public virtual DbSet<Delantales> Delantales { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Genero> Generos { get; set; } = null!;
        public virtual DbSet<Gorro> Gorros { get; set; } = null!;
        public virtual DbSet<Pantalones> Pantalones { get; set; } = null!;
        public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; } = null!;
        public virtual DbSet<TipoPago> TipoPagos { get; set; } = null!;
        public virtual DbSet<TipoProducto> TipoProductos { get; set; } = null!;
        public virtual DbSet<Uniforme> Uniformes { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<DetalleVenta> DetallesVenta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleVenta>().ToTable("DetalleFactura");
                        

            modelBuilder.Entity<Blusas>().ToTable("Blusas");

            modelBuilder.Entity<Cliente>().ToTable("Clientes");

            modelBuilder.Entity<Colores>(entity =>
            {
                entity.HasKey(e => e.IdColor);

                entity.Property(e => e.IdColor).HasColumnName("id_color");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("color");
            });

            modelBuilder.Entity<Delantales>(entity =>
            {
                entity.HasKey(e => e.IdDelantal);

                entity.Property(e => e.IdDelantal).HasColumnName("id_delantal");

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipoProducto");

                entity.Property(e => e.NombreDelantal)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreDelantal");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.Property(e => e.IdFactura).HasColumnName("id_factura");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaEntrega");

                entity.Property(e => e.FechaPedido)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaPedido");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdTipoPago).HasColumnName("id_tipoPago");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                /*entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facturas_Clientes");

                entity.HasOne(d => d.IdTipoPagoNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdTipoPago)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facturas_TipoPago");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facturas_Usuarios");*/
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.ToTable("Genero");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.Property(e => e.Genero1)
                    .HasMaxLength(10)
                    .HasColumnName("genero")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gorro>(entity =>
            {
                entity.HasKey(e => e.IdGorro);

                entity.Property(e => e.IdGorro).HasColumnName("id_gorro");

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipoProducto");

                entity.Property(e => e.NombreGorro)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreGorro");

                entity.Property(e => e.Precio).HasColumnName("precio");

               /* entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.Gorros)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gorros_TipoProducto");*/
            });

            modelBuilder.Entity<Pantalones>().ToTable("Pantalones");

            modelBuilder.Entity<TipoIdentificacion>().ToTable("TipoIdentificacion");

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.IdTipoPago);

                entity.ToTable("TipoPago");

                entity.Property(e => e.IdTipoPago).HasColumnName("id_tipoPago");

                entity.Property(e => e.TipoPago1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoPago");
            });

            modelBuilder.Entity<TipoProducto>().ToTable("TipoProducto");

            modelBuilder.Entity<Uniforme>(entity =>
            {
                entity.HasKey(e => e.IdUniforme);

                entity.Property(e => e.IdUniforme)
                    .ValueGeneratedNever()
                    .HasColumnName("id_uniforme");

                entity.Property(e => e.IdTipoProducto).HasColumnName("id_tipoProducto");

                entity.Property(e => e.NombreUniforme)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombreUniforme");

                entity.Property(e => e.Precio)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("precio");

                /*entity.HasOne(d => d.IdTipoProductoNavigation)
                    .WithMany(p => p.Uniformes)
                    .HasForeignKey(d => d.IdTipoProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Uniformes_TipoProducto");*/
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Estado)
                    .HasMaxLength(10)
                    .HasColumnName("estado")
                    .IsFixedLength();


                entity.Property(e => e.Identificacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identificacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
