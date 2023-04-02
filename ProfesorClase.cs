using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    internal class ProfesorClase
    {
        private string nombre;
        private string dni;
        private string telefono;
        private int codigoCurso;
        private List<string> listaAsignaturas;


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
        public ProfesorClase(string nombre, string dni, string telefono, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.codigoCurso = codigoCurso;
            listaAsignaturas = new List<string>();
        }

        public string textoListaAsignaturas()
        {
            string texto = "Asignaturas:";
            if(listaAsignaturas.Count > 0)
            {
                foreach(var asignatura in listaAsignaturas)
                {
                    texto += "\n\t\t" + asignatura;

                }
            }
            return texto;
        }

        public void datosProfesor()
        {
            string texto = "Datos del profesor: ";
            texto += "\n\tNombre: \t\t" + Nombre;
            texto += "\n\tDNI: \t\t" + Dni;
            texto += "\n\tTeléfono: \t" + Telefono;
            texto += "\n\tCurso: \t\t" + CodigoCurso;
            texto += "\n\t" + textoListaAsignaturas();

            MessageBox.Show(texto);
        }

        public void anadirAsignatura()
        {
            string asignatura = Interaction.InputBox("Nombre de la asignatura");
            listaAsignaturas.Add(asignatura);           
            
        }

        public void eliminarAsignaturas()
        {
            listaAsignaturas.Clear();
        }

        public bool imparteAsignatura(string asignatura)
        {
            bool encontrada = false;
            foreach(var asignaturas in listaAsignaturas)
            {
                if(asignaturas == asignatura)
                {
                    encontrada = true;
                }
            }
            return encontrada;
        }

    }
}
