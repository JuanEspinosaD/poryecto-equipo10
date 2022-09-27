using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.app.Dominio.Entidades
{
    public class Cliente : Persona
    {
        public string CiudadResidencia { get; set; }
        public string ClienteId { get; set; }
    }
}