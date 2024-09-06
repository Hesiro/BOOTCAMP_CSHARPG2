using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

[Table("Pedido")]
public partial class Pedido
{
    [Key]
    public int IdPedido { get; set; }

    public int? IdCliente { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPedido { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAnulacion { get; set; }

    [InverseProperty("IdPedidoNavigation")]
    public virtual Factura? Factura { get; set; }

    [ForeignKey("IdCliente")]
    [InverseProperty("Pedidos")]
    public virtual Cliente? IdClienteNavigation { get; set; }

    [InverseProperty("IdPedidoNavigation")]
    public virtual ICollection<LineasPedido> LineasPedidos { get; set; } = new List<LineasPedido>();
}
