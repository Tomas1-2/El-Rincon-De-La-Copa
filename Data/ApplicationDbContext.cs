using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using El_Rincon_De_La_Copa.Models;
namespace El_Rincon_De_La_Copa.Data;
public class ApplicationDbContext : IdentityDbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Categoria>? categoria { get; set; }
    public DbSet<Producto>? producto { get; set; }
    public DbSet<Pedido>? pedido { get; set; }
    public DbSet<DescripcionPedido>? descripcionPedido { get; set; }

}
