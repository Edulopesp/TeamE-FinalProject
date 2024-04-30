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

public DbSet<TeamE_Project.Models.Formacoes> Formacoes { get; set; } = default!;

public DbSet<TeamE_Project.Models.Utilizadores> Utilizadores { get; set; } = default!;

public DbSet<TeamE_Project.Models.Professores> Professores { get; set; } = default!;

public DbSet<TeamE_Project.Models.Dashboard> Dashboard { get; set; } = default!;

public DbSet<TeamE_Project.Models.Tipos> Tipos { get; set; } = default!;

public DbSet<TeamE_Project.Models.Cidades> Cidades { get; set; } = default!;

public DbSet<TeamE_Project.Models.Descricoes> Descricoes { get; set; } = default!;

public DbSet<TeamE_Project.Models.Area> Areas { get; set; } = default!;
}
