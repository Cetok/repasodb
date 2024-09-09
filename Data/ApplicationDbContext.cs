using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace repasodb.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<repasodb.Models.Cliente> DataCliente { get;set;}

    public DbSet<repasodb.Models.Contacto> DataContacto { get;set;}
}
