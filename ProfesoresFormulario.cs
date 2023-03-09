using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class ProfesoresFormulario : Form
    {
        List<ProfesorClase> ListadeProfesoresClaseACambiar = new List<ProfesorClase>();

        //TODO queda encampsulado y no se puede añadir ni sacar nada de la lista
        private ListadeProfesoresClase ListadeProfesores;
        public ProfesoresFormulario(ListadeProfesoresClase listadeProfesores)
        {
            InitializeComponent();
            this.ListadeProfesores = listadeProfesores;
        }

        //Introducir Profesor
        private void button1_Click(object sender, EventArgs e)
        {
            ProfesorClase profesor = new ProfesorClase();

            profesor.Nombre = Interaction.InputBox("Introduce el nombre el profesor");
            profesor.Dni = Interaction.InputBox("Introduce el DNI");
            profesor.Telefono = Interaction.InputBox("Introduce el teléfono");
            profesor.CodigoCurso = int.Parse(Interaction.InputBox("Introduce el código del curso"));

            ListadeProfesoresClaseACambiar.Add(profesor);

            //TODO no reconoce curso            
            //ListadeProfesores.Add(profesor);
        }

        //Eliminar Profesor
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeProfesoresClaseACambiar por ListadeProfesores cuando se pueda acceder a ella 
            string dni = Interaction.InputBox("Añadir DNI del profesor a borrar");
            foreach (var profesor in ListadeProfesoresClaseACambiar) //TODO salta
            {
                if (profesor.Dni == dni)
                {
                    ListadeProfesoresClaseACambiar.Remove(profesor);
                }
            }
            MessageBox.Show("profesor eliminado");
        }

        //Mostrar Lista Profesores
        private void button3_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeProfesoresClaseACambiar por ListadeProfesores cuando se pueda acceder a ella 
            string texto = "Profesores:";
            foreach (var profesor in ListadeProfesoresClaseACambiar)
            {
                texto += "\n" + profesor.Nombre;
            }

            MessageBox.Show(texto);
        }

        //Ordenar Profesores por Orden Alfabético
        private void button5_Click(object sender, EventArgs e)
        {
            //TODO ordenar por orden Alfabético
            ListadeProfesoresClaseACambiar.Sort(); //TODO salta
        }

        //Mostrar Datos Profesores
        private void button4_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeProfesoresClaseACambiar por ListadeProfesores cuando se pueda acceder a ella 
            string nombre = Interaction.InputBox("Introduce el nombre del profesor a mostrar");
            string texto = "Profesor:";
            foreach (var profesor in ListadeProfesoresClaseACambiar)
            {
                if (profesor.Nombre == nombre)
                {
                    texto += "\nNombre: " + profesor.Nombre + "\ndni: " + profesor.Dni + "\ntelefono: " + profesor.Telefono+"\nAsignaturas:";
                    foreach (var asignatura in profesor.ListaAsignaturas)
                    {
                        texto += "\n\t" + asignatura;
                    }
                }
            }
            MessageBox.Show(texto);
        }

        //Añadir Asignatura a Profesor
        private void button6_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeProfesoresClaseACambiar por ListadeProfesores cuando se pueda acceder a ella 
            string dni = Interaction.InputBox("Introduce el dni del profesor");

            foreach (var profesor in ListadeProfesoresClaseACambiar)
            {
                if (profesor.Dni == dni)
                {
                    string asignatura = Interaction.InputBox("Introducir asignaturas");
                    profesor.ListaAsignaturas.Add(asignatura);
                }
            }
        }

        //Eliminar las asignaturas de un Profesor
        private void button7_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeProfesoresClaseACambiar por ListadeProfesores cuando se pueda acceder a ella 
            string dni = Interaction.InputBox("Introduce el dni del profesor para eliminar sus asignaturas");
            foreach (var profesor in ListadeProfesoresClaseACambiar)
            {
                if (profesor.Dni == dni)
                {
                    profesor.ListaAsignaturas.Clear();
                }
            }
        }

        //Mostrar profesores que imparten una asignatura
        private void button8_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeProfesoresClaseACambiar por ListadeProfesores cuando se pueda acceder a ella 
            int codigoCurso = int.Parse(Interaction.InputBox("Introduce el curso para saber sus alumnos"));
            string texto = "Asignatura " + codigoCurso;
            foreach (var profesor in ListadeProfesoresClaseACambiar)
            {
                if (profesor.CodigoCurso == codigoCurso)
                {
                    texto += "\n" + profesor.Nombre;
                }
            }
            MessageBox.Show(texto);
        }
    }
}
