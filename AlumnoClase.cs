using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<double> ListaNotas
        {
            get => listaNotas;
            set => listaNotas = value;
        }
        public int CodigoCurso { get => codigoCurso; set => codigoCurso = value; }

        //Constructor
        public AlumnoClase()
        {
            nombre = "";
            dni = "";
            telefono = "";
            codigoCurso = 0;
            listaNotas = new List<double>();
        }
        public AlumnoClase(string nombre, string dni, string telefono, int codigoCurso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.codigoCurso = codigoCurso;
            listaNotas = new List<double>();
        }

        public string textoListaNotas()
        {
            string texto = "Notas:";
            if(ListaNotas.Count > 0)
            {
                foreach(var nota in ListaNotas)
                {
                    texto += "\n\t\t" + nota;

                }
            }
            return texto;
        }

        public void datosAlumno()
        {
            string texto = "Datos del alumno: ";
            texto += "\n\tNombre: \t\t" + Nombre;
            texto += "\n\tDNI: \t\t" + Dni;
            texto += "\n\tTeléfono: \t" + Telefono;
            texto += "\n\tCurso: \t\t" + CodigoCurso;
            texto += "\n\t" + textoListaNotas();

            MessageBox.Show(texto);
        }

        public void anadirNotas()
        {
            try
            {
                int numeroDeNotas = int.Parse(Interaction.InputBox("Número de notas a añadir:"));
                for(int i = 0; i < numeroDeNotas; i++)
                {
                    int nota = int.Parse(Interaction.InputBox("Nota a añadir "+(i+1)+":"));
                    if(nota > 0 && nota < 10)
                    {
                        ListaNotas.Add(nota);
                    }
                    else
                    {
                        MessageBox.Show("Nota incorrecta");
                    }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Formato incorrecto");

            }
        }

        public void eliminarNotas()
        {
            listaNotas.Clear();
        }

        public string ListaNotasMayorCinco()
        {
            string texto = "";
            double notaMedia = 0;
            foreach(var nota in listaNotas)
            {
                notaMedia += nota;
            }
            notaMedia = notaMedia / listaNotas.Count;
                if(notaMedia >= 5)
                {
                    texto += "\n\t" + Nombre + "\t" + notaMedia;
                }
            return texto;
        }

        public string ListaNotasMenorCinco()
        {
            string texto = "";
            double notaMedia = 0;
            foreach(var nota in listaNotas)
            {
                notaMedia += nota;
            }
            notaMedia = notaMedia / listaNotas.Count;
            if(notaMedia < 5)
            {
                texto += "\n\t" + Nombre + "\t" + notaMedia;
            }
            return texto;
        }



    }

}
