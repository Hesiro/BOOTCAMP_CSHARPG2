using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

public partial class BootcampContext : DbContext
{
    public BootcampContext()
    {
    }

    public BootcampContext(DbContextOptions<BootcampContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<LineasPedido> LineasPedidos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<VistaPedidosDetalle> VistaPedidosDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__D5946642611C4C73");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Factura__50E7BAF159B10849");

            entity.HasOne(d => d.IdPedidoNavigation).WithOne(p => p.Factura).HasConstraintName("fk_id_pedido_factura");
        });

        modelBuilder.Entity<LineasPedido>(entity =>
        {
            entity.HasKey(e => e.IdLineaPedido).HasName("PK__Lineas_P__35430C949EFD03DF");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.LineasPedidos).HasConstraintName("fk_id_pedido_linea_pedido");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.LineasPedidos).HasConstraintName("fk_id_producto_linea_pedido");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__Pedido__9D335DC3399623EF");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos).HasConstraintName("fk_id_cliente_pedido");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__09889210A12731D9");
        });

        modelBuilder.Entity<VistaPedidosDetalle>(entity =>
        {
            entity.ToView("VistaPedidosDetalles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
