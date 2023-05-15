namespace El_Rincon_De_La_Copa.Models;

public class DescripcionPedido
{
    public int ID { get; set; }
    public int IDProducto { get; set; }
    public int CantidadSolicitada { get; set; }
    public decimal Total { get; set; }
}
