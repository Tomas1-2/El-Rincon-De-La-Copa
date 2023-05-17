using System.ComponentModel.DataAnnotations;
namespace El_Rincon_De_La_Copa.Models;
public class DescripcionPedido
{
    [Key]
    public int ID { get; set; }
    public int IDProducto { get; set; }
    public string? NombreProducto { get; set; }
    public int CantidadSolicitada { get; set; }
    public decimal SubTotal { get; set; }
    public virtual Pedido? Pedido { get; set; }
}
