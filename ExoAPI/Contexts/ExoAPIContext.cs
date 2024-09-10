using ExoAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace ExoAPI.Contexts
{
    public class ExoAPIContext : DbContext
    {
        public ExoAPIContext()
        {

        }
        public ExoAPIContext(DbContextOptions<ExoAPIContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 

                optionsBuilder.UseSqlServer("Data Source = DESKTOP-MCJPTHS\\SQLEXPRESS; initial catalog = ExoApi; Integrated Security = true; TrustServerCertificate = true");
            }
         }   

        public DbSet<Projeto> Projetos { get; set; }
    }
}
