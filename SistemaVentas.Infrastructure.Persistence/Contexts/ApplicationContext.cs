using Microsoft.EntityFrameworkCore;
using SistemaVentas.Core.Domain.Common;
using SistemaVentas.Core.Application.Helpers;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.Core.Domain.Entities;

namespace SistemaVentas.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        private readonly UserSessionHelper _userSessionHelper;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IServiceProvider serviceProvider) : base(options)
        {
            _userSessionHelper = serviceProvider.GetRequiredService<UserSessionHelper>();
        }

        public DbSet<ProductoEntity> Productos;
        public DbSet<ImagenProductoEntity> ImagenenProductos;
        public DbSet<MarcaEntity> Marcas;
        public DbSet<CategoriaEntity> Categorias;
        public DbSet<InventarioEntity> Inventarios;
        public DbSet<DireccionEntity> Direcciones;
        public DbSet<CarritoCompraEntity> CarritoCompras;
        public DbSet<VentaEntity> Ventas;

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new()) {
            var loggedUser = await _userSessionHelper.GetUser();
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.CreatedBy = loggedUser.FirstName + loggedUser.LastName;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModified = DateTime.Now;
                        entry.Entity.LastModifyBy = loggedUser.FirstName + loggedUser.LastName;
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region tables
            modelBuilder.Entity<ProductoEntity>().ToTable("Productos");
            modelBuilder.Entity<ImagenProductoEntity>().ToTable("ImagenProductos");
            modelBuilder.Entity<MarcaEntity>().ToTable("Marcas");
            modelBuilder.Entity<CategoriaEntity>().ToTable("Categorias");
            modelBuilder.Entity<InventarioEntity>().ToTable("Inventarios");
            modelBuilder.Entity<DireccionEntity>().ToTable("Direcciones");
            modelBuilder.Entity<CarritoCompraEntity>().ToTable("CarritoCompras");
            modelBuilder.Entity<VentaEntity>().ToTable("Ventas");
            #endregion

            #region "primary keys"
            modelBuilder.Entity<ProductoEntity>().HasKey(entity => entity.Id);//lambda
            modelBuilder.Entity<ImagenProductoEntity>().HasKey(entity => entity.Id);
            modelBuilder.Entity<MarcaEntity>().HasKey(entity => entity.Id);
            modelBuilder.Entity<CategoriaEntity>().HasKey(entity => entity.Id);
            modelBuilder.Entity<InventarioEntity>().HasKey(entity => entity.Id);
            modelBuilder.Entity<DireccionEntity>().HasKey(entity => entity.Id);
            modelBuilder.Entity<CarritoCompraEntity>().HasKey(entity => entity.Id);
            modelBuilder.Entity<VentaEntity>().HasKey(entity => entity.Id);

            #endregion

            #region relationships
            modelBuilder.Entity<ProductoEntity>()
                .HasOne<MarcaEntity>(product=> product.Marca)
                .WithMany(marca => marca.Productos)
                .HasForeignKey(product => product.MarcaId);

            modelBuilder.Entity<ProductoEntity>()
                .HasMany<ImagenProductoEntity>(product => product.Imagenes)
                .WithOne(imagen => imagen.Producto)
                .HasForeignKey(product => product.ProductoId);

            modelBuilder.Entity<ProductoEntity>()
                .HasMany<CategoriaEntity>(product => product.Categorias)
                .WithMany(categoria => categoria.Productos)
                .UsingEntity(j => j.ToTable("CategoriaProductos"));





            #endregion

            #region property configurations

            #region Producto
            modelBuilder.Entity<ProductoEntity>(entity =>
            {
                entity.Property(p => p.Nombre).IsRequired();
                entity.Property(p => p.Precio).HasColumnType("decimal(18,2)").IsRequired();
                entity.Property(p => p.Descripcion).HasMaxLength(2000).IsRequired();
                entity.Property(p => p.Status).HasMaxLength(2).IsRequired();
            });
            #endregion

            #region Marca
            modelBuilder.Entity<MarcaEntity>(entity =>
            {
                entity.Property(m => m.Nombre).HasMaxLength(500).IsRequired();
            });
            #endregion

            #region ImagenProducto
            modelBuilder.Entity<ImagenProductoEntity>(entity =>
            {
                entity.Property(m => m.RutaImagen).IsRequired();
            });
            #endregion

            #region Inventario
            modelBuilder.Entity<InventarioEntity>(entity =>
            {
                entity.Property(m => m.CantidadDisponible).HasMaxLength(100).IsRequired();
                entity.Property(m => m.Zize).HasMaxLength(30).IsRequired();
                entity.Property(m => m.Color).HasMaxLength(50).IsRequired();
            });
            #endregion

            #region Direccion
            modelBuilder.Entity<DireccionEntity>(entity =>
            {
                entity.Property(m => m.Sector).HasMaxLength(100).IsRequired();
                entity.Property(m => m.Calle).HasMaxLength(100).IsRequired();
                entity.Property(m => m.NumeroCelular).HasMaxLength(50).IsRequired();
                entity.Property(m => m.NumeroCasa).HasMaxLength(50).IsRequired();
                entity.Property(m => m.UserId).IsRequired();

            });
            #endregion

            #region CarritoCompra
            modelBuilder.Entity<CarritoCompraEntity>(entity =>
            {
                entity.Property(m => m.Subtotal).HasColumnType("decimal(18,2)").IsRequired();
                entity.Property(m => m.Total).HasColumnType("decimal(18,2)").IsRequired();
                entity.Property(m => m.MetodoEntrega).HasMaxLength(10).IsRequired();
                entity.Property(m => m.Ubicacion).HasMaxLength(500);
                entity.Property(m => m.TelefonoContacto).HasMaxLength(50).IsRequired();

            });
            #endregion

            #region Venta
            modelBuilder.Entity<VentaEntity>(entity =>
            {
                entity.Property(m => m.Estado).HasMaxLength(5).IsRequired();
                entity.Property(m => m.MontoPagado).HasColumnType("decimal(18,2)").IsRequired();
            });
            #endregion

            #endregion

        }
    }
}
