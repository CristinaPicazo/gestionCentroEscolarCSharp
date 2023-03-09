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

        //Propiedades
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


        //constructor
        public CursoClase()
        {
            codigo= 0;
            nombre = "";
        }
        public CursoClase(int codigo, string nombre)
        {
            this.nombre = nombre;
            this.codigo= codigo;    
        }
        
    }
}
