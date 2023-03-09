using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class ProfesorClase
    {
        private string nombre;
        private string dni;
        private string telefono;
        private List<string> listaAsignaturas;
        private int codigoCurso;


        //propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<string> ListaAsignaturas { get => listaAsignaturas; set => listaAsignaturas = value; }
        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }

        //constructor
        public ProfesorClase()
        {
            nombre = "";
            dni = "";
            telefono = "";
            listaAsignaturas = new List<string>();
            codigoCurso = 0;

        }
        public ProfesorClase(string nombre, string dni, string telefono, List<string> listaAsignaturas, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.listaAsignaturas = new List<string>();
            this.codigoCurso = codigoCurso;
        }

    }
}
