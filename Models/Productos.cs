using System.ComponentModel.DataAnnotations;

namespace El_Rincon_De_La_Copa.Models;
public class Producto 
{
    [Key]
    public int ID { get; set; }
    public int IDCategoria { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
    public virtual Categoria? Categoria { get; set; }
}
