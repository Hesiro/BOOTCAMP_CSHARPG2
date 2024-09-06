using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

[Table("Producto")]
public partial class Producto
{
    [Key]
    public int IdProducto { get; set; }

    public Guid? CodProducto { get; set; }

    [Column("PVP")]
    public double? Pvp { get; set; }

    public double? PrecioCompra { get; set; }

    public bool? Tangible { get; set; }

    public double? IvaActual { get; set; }

    public int? StockDisponible { get; set; }

    [InverseProperty("IdProductoNavigation")]
    public virtual ICollection<LineasPedido> LineasPedidos { get; set; } = new List<LineasPedido>();
}
