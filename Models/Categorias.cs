using System.ComponentModel.DataAnnotations;

namespace El_Rincon_De_La_Copa.Models;

public class Categoria
{
    [Key]
    public int ID { get; set; }
    public string? Nombre { get; set; }
    public virtual ICollection<Producto>? Productos { get; set; }
}