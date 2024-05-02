using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamE_Project.Models;

namespace TeamE_Project.Areas.Identity.Data;

public class DataContext : IdentityDbContext<IdentityUser>
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<TeamE_Project.Models.Formacao> Formacao { get; set; } = default!;

public DbSet<TeamE_Project.Models.Utilizador> Utilizador { get; set; } = default!;

public DbSet<TeamE_Project.Models.Formador> Formador { get; set; } = default!;

public DbSet<TeamE_Project.Models.Dashboard> Dashboard { get; set; } = default!;

public DbSet<TeamE_Project.Models.Tipo> Tipo { get; set; } = default!;

public DbSet<TeamE_Project.Models.Cidade> Cidade { get; set; } = default!;

public DbSet<TeamE_Project.Models.Nome> Nome { get; set; } = default!;

public DbSet<TeamE_Project.Models.Area> Area { get; set; } = default!;
}
