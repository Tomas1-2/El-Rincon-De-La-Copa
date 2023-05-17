using System.ComponentModel.DataAnnotations;

namespace El_Rincon_De_La_Copa.Models;

public class Estado
{
    [Key]
    public int ID { get; set; }
    public bool Entregado { get; set; }
    public bool EnCurso { get; set; }
    public bool NoEnviado { get; set; }
    public virtual Pedido? Pedido { get; set; }
}