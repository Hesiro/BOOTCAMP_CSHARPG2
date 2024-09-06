using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

[Table("Lineas_Pedido")]
public partial class LineasPedido
{
    [Key]
    public int IdLineaPedido { get; set; }

    public int? IdPedido { get; set; }

    public int? IdProducto { get; set; }

    [Column("PVP")]
    public double? Pvp { get; set; }

    public int? Cantidad { get; set; }

    public double? IvaDetalle { get; set; }

    [ForeignKey("IdPedido")]
    [InverseProperty("LineasPedidos")]
    public virtual Pedido? IdPedidoNavigation { get; set; }

    [ForeignKey("IdProducto")]
    [InverseProperty("LineasPedidos")]
    public virtual Producto? IdProductoNavigation { get; set; }
}
