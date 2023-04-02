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
        private ListadeProfesoresClase listadeProfesores;
        public ProfesoresFormulario(ListadeProfesoresClase listadeProfesores)
        {
            InitializeComponent();
            this.listadeProfesores = listadeProfesores;
        }

        //Introducir Profesor
        private void button1_Click(object sender, EventArgs e)
        {
            listadeProfesores.anadirProfesor();            
        }

        //Eliminar Profesor
        private void button2_Click(object sender, EventArgs e)
        {
            listadeProfesores.eliminarProfesor();            
        }

        //Mostrar Lista Profesores
        private void button3_Click(object sender, EventArgs e)
        {
            listadeProfesores.mostrarListaProfesores();          
        }

        //Ordenar Profesores por Orden Alfabético
        private void button5_Click(object sender, EventArgs e)
        {
            listadeProfesores.ordenarProfesores();
        }

        //Mostrar Datos Profesores
        private void button4_Click(object sender, EventArgs e)
        {
            listadeProfesores.mostrarDatosProfesores();            
        }

        //Añadir Asignatura a Profesor
        private void button6_Click(object sender, EventArgs e)
        {
            listadeProfesores.anadirAsignaturaAProfesor();
        }

        //Eliminar las asignaturas de un Profesor
        private void button7_Click(object sender, EventArgs e)
        {
            listadeProfesores.eliminarAsignaturaAProfesor();

        }

        //Mostrar profesores que imparten una asignatura
        private void button8_Click(object sender, EventArgs e)
        {
            listadeProfesores.mostrarProfesorPorAsignatura();
        }
    }
}
