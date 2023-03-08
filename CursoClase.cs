using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class CursoClase
    {
        private string nombre;
        private int codigo;


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;

            }
        }
    }
}
