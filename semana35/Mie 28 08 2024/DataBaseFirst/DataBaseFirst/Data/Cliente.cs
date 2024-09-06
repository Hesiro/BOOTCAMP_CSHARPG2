using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Data;

[Table("Cliente")]
public partial class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Cif { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [MaxLength(500)]
    public byte[]? Password { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAlta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaBaja { get; set; }

    [InverseProperty("IdClienteNavigation")]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
