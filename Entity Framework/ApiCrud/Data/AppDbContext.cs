using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=COMPUTADORARTUR\\SQLEXPRESS; Database=MeuBancoTeste;Trusted_Connection=True; TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }
    }
}