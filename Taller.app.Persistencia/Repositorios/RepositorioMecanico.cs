using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.app.Dominio.Entidades;

namespace Taller.app.Persistencia
{
    public class RepositorioMecanico
    {
        private readonly ContextDb dbContext;

        public RepositorioMecanico(ContextDb dbContext)
        {

            this.dbContext = dbContext;
        }

        public Mecanico AgregarMecanico(Mecanico m)
        {

            var mecanicoNuevo = this.dbContext.Mecanicos.Add(m);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity;
        }

        public IEnumerable<Mecanico> ObtenerMecanicos()
        {
            return this.dbContext.Mecanicos;
        }

        public Mecanico BuscarMecanico(string idMecanico)
        {
            return this.dbContext.Mecanicos.FirstOrDefault(m => m.MecanicoId == idMecanico);
        }

        public void EditarMecanico(Mecanico mecanicoNuevo, string id)
        {
            var mecanicoActual = this.dbContext.Mecanicos.FirstOrDefault(m => m.MecanicoId == id);
            if (mecanicoActual != null)
            {
                mecanicoActual.Nombres = mecanicoNuevo.Nombres;
                mecanicoActual.FechaNacimiento = mecanicoNuevo.FechaNacimiento;
                mecanicoActual.Telefono = mecanicoNuevo.Telefono;
                mecanicoActual.Contrasenia = mecanicoNuevo.Contrasenia;
                mecanicoActual.Rol = mecanicoNuevo.Rol;
                mecanicoActual.NivelEstudio = mecanicoNuevo.NivelEstudio;
                this.dbContext.SaveChanges();
            }
        }

        public void EliminarMecanico(string idMecanico)
        {
            var mecanicoEncontrado = this.dbContext.Mecanicos.FirstOrDefault(m => m.MecanicoId == idMecanico);

            if (mecanicoEncontrado != null)
            {
                this.dbContext.Mecanicos.Remove(mecanicoEncontrado);
                this.dbContext.SaveChanges();

            }

        }
    }
}
