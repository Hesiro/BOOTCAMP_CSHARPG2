using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

[Keyless]
public partial class VistaPedidosDetalle
{
    public int IdCliente { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? NombreCliente { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? EmailCliente { get; set; }

    public int IdPedido { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPedido { get; set; }

    public int IdProducto { get; set; }

    public Guid? CodProducto { get; set; }

    [Column("PVP")]
    public double? Pvp { get; set; }

    public int? Cantidad { get; set; }

    public double? TotalLinea { get; set; }
}
