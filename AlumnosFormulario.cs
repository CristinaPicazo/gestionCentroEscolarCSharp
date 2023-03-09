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
    public partial class AlumnosFormulario : Form
    {
        //He creado esta lista porque no consigo sacar la que viene del formulario inicial
        List<AlumnoClase> ListadeAlumnosClaseACambiar = new List<AlumnoClase>();

        //TODO queda encampsulado y no se puede añadir ni sacar nada de la lista
        private ListadeAlumnosClase listaAlumnos;
        public AlumnosFormulario(ListadeAlumnosClase listaAlumnos)
        {
            InitializeComponent();
            this.listaAlumnos = listaAlumnos;
        }

        //Introducir Alumno
        private void button1_Click(object sender, EventArgs e)
        {
            AlumnoClase alumno = new AlumnoClase();

            alumno.Nombre = Interaction.InputBox("Introduce el nombre el alumno");
            alumno.Dni = Interaction.InputBox("Introduce el DNI");
            alumno.Telefono = Interaction.InputBox("Introduce el teléfono");
            alumno.CodigoCurso = int.Parse(Interaction.InputBox("Introduce el código del curso"));

            ListadeAlumnosClaseACambiar.Add(alumno);

            //TODO no reconoce curso            
            //listaAlumnos.Add(alumno);

        }

        //Eliminar Alumno
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string dni = Interaction.InputBox("Añadir DNI del alumno a borrar");
            foreach (var alumno in ListadeAlumnosClaseACambiar) //TODO salta aqui
            {
                if (alumno.Dni == dni)
                {
                    ListadeAlumnosClaseACambiar.Remove(alumno);
                }
            }
            MessageBox.Show("Alumno eliminado");
        }

        //Mostrar Lista Alumnos
        private void button3_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string texto = "Alumnos:";
            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                texto += "\n" + alumno.Nombre;
            }

            MessageBox.Show(texto);
        }

        //Ordenar Alumnos por Orden Alfabético
        private void button5_Click(object sender, EventArgs e)
        {
            //TODO ordenar por orden Alfabético
            ListadeAlumnosClaseACambiar.Sort(); //TODO salta aqui
        }

        //Mostrar Datos Alumno (por nombre)
        private void button4_Click(object sender, EventArgs e) //TODO añadir lista notas
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string nombre = Interaction.InputBox("Introduce el nombre del alumno a mostrar");
            string texto = "Profesor:";

            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                if (alumno.Nombre == nombre)
                {
                    texto += "\nNombre: " + alumno.Nombre + "\ndni: " + alumno.Dni + "\ntelefono: " + alumno.Telefono + "\nNotas:";
                    foreach (var notas in alumno.ListaNotas)
                    {
                        texto += "\n\t" + notas;
                    };
                }
            }
            MessageBox.Show(texto);

        }

        //Mostrar alumnos pertenecientes a un curso
        private void button6_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string texto = "Alumnos:";
            int codigoCurso = int.Parse(Interaction.InputBox("Introduce el curso para saber sus alumnos"));
            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                if (alumno.CodigoCurso == codigoCurso)
                {
                    texto += "\n"+alumno.Nombre;
                }
            }
            MessageBox.Show(texto);
        }

        //Añadir notas a Alumno
        private void button7_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string dni = Interaction.InputBox("Introduce el dni el alumno");

            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                if(alumno.Dni == dni)
                {
                    int numeroDeNotasAIntroducir = int.Parse(Interaction.InputBox("Número de notas a introducir"));
                    for (int i = 0; i < numeroDeNotasAIntroducir; i++)
                    {
                        alumno.ListaNotas.Add(int.Parse(Interaction.InputBox("Nota "+i+":")));
                    }
                }
            }
        }

        //Mostrar alumnos con nota media mayor o igual a 5
        private void button8_Click(object sender, EventArgs e) //TODO no entra
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string texto = "Alumnos con nota mayor a 5";
            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                double sumaTodaNotas = 0;
                foreach (var notas in alumno.ListaNotas)
                {
                    sumaTodaNotas += notas;
                }
                if((sumaTodaNotas/alumno.ListaNotas.Count) >= 5)
                {
                    texto += "\nAlumno: " + alumno.Nombre;
                }               
            }

        }

        //Eliminar las notas de un alumno
        private void button9_Click(object sender, EventArgs e) //TODO falta probarlo
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string dni = Interaction.InputBox("Introduce el dni del alumno para eliminar sus notas");
            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                if(alumno.Dni == dni)
                {
                    alumno.ListaNotas.Clear();
                }
            }
        }

        //Mostrar alumnos con nota media menor a 5
        private void button10_Click(object sender, EventArgs e) //TODO no entra
        {
            //TODO cambiar ListadeAlumnosClaseACambiar por listaAlumnos cuando se pueda acceder a ella 
            string texto = "Alumnos con nota mayor a 5";
            foreach (var alumno in ListadeAlumnosClaseACambiar)
            {
                double sumaTodaNotas = 0;
                foreach (var notas in alumno.ListaNotas)
                {
                    sumaTodaNotas += notas;
                }
                if ((sumaTodaNotas / alumno.ListaNotas.Count) < 5)
                {
                    texto += "\nAlumno: " + alumno.Nombre;
                }
            }
        }
    }
}
