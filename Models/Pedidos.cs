using System.ComponentModel.DataAnnotations;

namespace El_Rincon_De_La_Copa.Models;

public class Pedido
{
    [Key]
    public int ID { get; set; }
    public int Usuario { get; set; }
    public string? Direccion { get; set; }
    public List<Estado>? Estados { get; set; }
    public List<DescripcionPedido>? DescripcionesPedido { get; set; }
    public decimal Total { get; set; }
}