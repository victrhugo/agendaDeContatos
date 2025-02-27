using Microsoft.EntityFrameworkCore;

public class AgendaContext : DbContext
{
    public DbSet<Contato> Contatos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-6H5PBKR\\SQLVICTOR;Database=agendaDeContatos;Integrated Security=True;TrustServerCertificate=True;");
    }
}
