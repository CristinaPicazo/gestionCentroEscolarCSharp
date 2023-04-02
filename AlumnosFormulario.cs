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
        private ListadeAlumnosClase listaAlumnos;
        public AlumnosFormulario(ListadeAlumnosClase listaAlumnos)
        {
            InitializeComponent();
            this.listaAlumnos = listaAlumnos;
        }

        //Introducir Alumno
        private void button1_Click(object sender, EventArgs e)
        {
            listaAlumnos.anadirAlumno();
        }

        //Eliminar Alumno
        private void button2_Click(object sender, EventArgs e)
        {
            listaAlumnos.eliminarAlumno();
        }
        
        //Mostrar Lista Alumnos
        private void button3_Click(object sender, EventArgs e)
        {
            listaAlumnos.mostrarListaAlumnos();            
        }

        //Ordenar Alumnos por Orden Alfabético
        private void button5_Click(object sender, EventArgs e)
        {
            listaAlumnos.ordenarAlumnos();
        }

        //Mostrar Datos Alumno (por nombre)
        private void button4_Click(object sender, EventArgs e)
        {
            listaAlumnos.mostrarDatosNombre();            

        }

        //Mostrar alumnos pertenecientes a un curso
        private void button6_Click(object sender, EventArgs e)
        {

            listaAlumnos.mostrarAlumnosCurso();
            
        }

        //Añadir notas a un Alumno
        private void button7_Click(object sender, EventArgs e)
        {
            listaAlumnos.anadirNotasAlumno();
        }


        //Eliminar las notas de un alumno
        private void button9_Click(object sender, EventArgs e) 
        {
            listaAlumnos.eliminarNotasAlumno();
           
        }

        //Mostrar alumnos con nota media mayor o igual a 5
        private void button8_Click(object sender, EventArgs e) 
        {
            listaAlumnos.notasMayorCinco();          

        }

        //Mostrar alumnos con nota media menor a 5
        private void button10_Click(object sender, EventArgs e)
        {
            listaAlumnos.notasMenorCinco();
            
        }
    }
}
