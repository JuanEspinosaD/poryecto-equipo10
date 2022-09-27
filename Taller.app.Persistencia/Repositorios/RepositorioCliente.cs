using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.app.Dominio.Entidades;

namespace Taller.app.Persistencia
{
    public class RepositorioCliente
    {
        private readonly ContextDb dbContext;

        public RepositorioCliente(ContextDb dbContext)
        {
            this.dbContext = dbContext;
        }

        public Cliente AgregarCliente(Cliente c)
        {
            var revisionNueva = this.dbContext.Clientes.Add(c);
            this.dbContext.SaveChanges();
            return revisionNueva.Entity;
        }
        public IEnumerable<Cliente> ObtenerClientes()
        {
            return this.dbContext.Clientes;
        }

        public Cliente BuscarCliente(string idCliente)
        {
            return this.dbContext.Clientes.FirstOrDefault(c => c.ClienteId == idCliente);
        }

        public void EditarCliente(Cliente clienteNuevo, string id)
        {
            var clienteActual = this.dbContext.Clientes.FirstOrDefault(c => c.ClienteId == id);
            if (clienteActual != null)
            {
                clienteActual.Nombres = clienteNuevo.Nombres;
                clienteActual.FechaNacimiento = clienteNuevo.FechaNacimiento;
                clienteActual.CiudadResidencia = clienteNuevo.CiudadResidencia;
                clienteActual.Telefono = clienteNuevo.Telefono;
                clienteActual.Contrasenia = clienteNuevo.Contrasenia;
                this.dbContext.SaveChanges();
            }
        }

        public void EliminarCliente(string idCliente)
        {
            var clienteEncontrado = this.dbContext.Clientes.FirstOrDefault(c => c.ClienteId == idCliente);

            if (clienteEncontrado != null)
            {
                this.dbContext.Clientes.Remove(clienteEncontrado);
                this.dbContext.SaveChanges();

            }

        }
    }
}