using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_G4
{
    class Persona
    {
        string nombre;
        string usuario;
        string codigo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
