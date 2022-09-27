using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.app.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Taller.app.Persistencia
{
    public class ContextDb : DbContext
    {


        public virtual DbSet<Mecanico> Mecanicos { get; set; }
        public DbSet<Revision> Revisions { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=tcp:server-tallertic-10.database.windows.net,1433;Initial Catalog=bd_taller;Persist Security Info=False;User ID=admintic;Password=Josearrieta2311;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

    }
}