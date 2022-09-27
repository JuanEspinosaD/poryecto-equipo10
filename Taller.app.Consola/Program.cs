using System;
using Taller.app.Persistencia;
using Taller.app.Dominio.Entidades;


namespace Taller.app.Consola
{
    class Program
    {
        private  static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );

        static void Main(string[] args)
        {
      
        }

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                MecanicoId = "30",
                Nombres = "Lina",
                Apellidos = "",
                FechaNacimiento = "31/12/2000",
                NivelEstudio = "QA",
                Telefono = "345",
                Contrasenia = "678",
                Rol = "Mecanico"
                
            };
            repoMecanico.AgregarMecanico(mecanico);
        }

        static void ObtenerMecanicos()
        {


            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                Console.WriteLine(mecanico.MecanicoId + ", Nombre: " + mecanico.Nombres);
            }
        }

        static void BuscarMecanico(string id)
        {

            var mecanico = repoMecanico.BuscarMecanico(id);
            Console.WriteLine("---------");
            Console.WriteLine("Nombre: " + mecanico.Nombres + "\nNivel estudio: " + mecanico.NivelEstudio);
            Console.WriteLine("---------");
        }

        static void EditarMecanico(string id)
        {

            var mecanico = new Mecanico
            {
                MecanicoId = "",
                Nombres = "Fercho",
                FechaNacimiento = "20",
                NivelEstudio = "Profesional",
                Telefono = "123",
                Contrasenia = "123",
                Rol = "jefeoperaciones"
                
            };
            repoMecanico.EditarMecanico(mecanico, id);
        }


        static void EliminarMecanico(string id)
        {
            repoMecanico.EliminarMecanico(id);
        }


        private  static RepositorioCliente repoCliente = new RepositorioCliente(
            new Persistencia.ContextDb()
        );


        static void AgregarCliente()
        {
            var cliente = new Cliente
            {
                ClienteId = "30",
                Nombres = "Lina",
                Apellidos = "Perez",
                FechaNacimiento = "31/12/2000",
                CiudadResidencia = "CAli",
                Telefono = "345",
                Contrasenia = "678",
                
            };
            repoCliente.AgregarCliente(cliente);
        }

        static void ObtenerClientes()
        {

            foreach (Cliente cliente in repoCliente.ObtenerClientes())
            {
                Console.WriteLine(cliente.ClienteId + ", Nombre: " + cliente.Nombres);
            }
        }

         static void BuscarCliente(string id)
        {

            var cliente = repoCliente.BuscarCliente(id);
            Console.WriteLine("---------");
            Console.WriteLine("Nombre: " + cliente.Nombres + "\nNivel estudio: " + cliente.CiudadResidencia);
            Console.WriteLine("---------");
        }

        static void EditarCliente(string id)
        {

            var cliente = new Cliente
            {
                ClienteId = "",
                Nombres = "jose",
                FechaNacimiento = "20",
                CiudadResidencia = "monteria",
                Telefono = "123",
                Contrasenia = "123",
                
            };
            repoCliente.EditarCliente(cliente, id);
        }

        static void EliminarCliente(string id)
        {
            repoCliente.EliminarCliente(id);
        }




    }

}
