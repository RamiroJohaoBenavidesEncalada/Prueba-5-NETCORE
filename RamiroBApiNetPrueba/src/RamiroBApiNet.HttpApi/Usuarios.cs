using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamiroBApiNet.HttpApi
{
    public class Usuarios
    {
        public Usuarios(string Nombre, string Cedula)
        {
            this.Nombre = Nombre;
            this.Cedula = Cedula;
        }

        //public int Id{get;set;}
        public string Cedula{get;set;}
        public string Nombre{get;set;}
    }
}