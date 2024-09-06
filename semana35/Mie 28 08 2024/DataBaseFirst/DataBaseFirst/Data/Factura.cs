using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

[Table("Factura")]
[Index("IdPedido", Name = "UQ__Factura__9D335DC2F2AA05F3", IsUnique = true)]
public partial class Factura
{
    [Key]
    public int IdFactura { get; set; }

    public int? IdPedido { get; set; }

    public double? TotalProductos { get; set; }

    public double? TotalIva { get; set; }

    public double? TotalFactura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaFactura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAnulacion { get; set; }

    [ForeignKey("IdPedido")]
    [InverseProperty("Factura")]
    public virtual Pedido? IdPedidoNavigation { get; set; }
}
