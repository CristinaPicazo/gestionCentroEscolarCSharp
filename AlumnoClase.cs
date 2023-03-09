using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio6
{
    internal class AlumnoClase
    {
        private string nombre;
        private string dni;
        private string telefono;
        private List<double> listaNotas;
        private int codigoCurso;

        //Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public List<double> ListaNotas { get => listaNotas; set => listaNotas = value; }
        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }

        //Constructor
        public AlumnoClase()
        {
            nombre = "";
            dni = "";
            telefono = "";
            listaNotas = new List<double>();
            codigoCurso = 0;
        }
        public AlumnoClase(string nombre, string dni, string telefono, List<double> listaNotas, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.listaNotas = new List<double>();
            this.codigoCurso= codigoCurso;
        }

    }

}
