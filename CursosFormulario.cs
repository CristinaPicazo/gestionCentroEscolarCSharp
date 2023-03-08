using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;

namespace Ejercicio6
{
    public partial class CursosFormulario : Form
    {
        private ListadeCursosClase listaCursos;
        public CursosFormulario(ListadeCursosClase listaCursos)
        {
            InitializeComponent();
            this.listaCursos = listaCursos;
        }
        //añadir curso
        private void button1_Click(object sender, EventArgs e)
        {

            int codigo = int.Parse(Interaction.InputBox("Código del curso"));
            string nombre = Interaction.InputBox("Nombre del curso");

            //añadirCurso(codigo, nombre);
        }

        //eliminar curso
        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(Interaction.InputBox("Añadir código del curso a borrar"));
            //borrarCurso(codigo);
        }

        //mostrar todos los cursos
        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(Interaction.InputBox("Añadir código del curso a borrar"));
            //mostrarTodosCursos(codigo);

        }

        //mostrar todos los alumnos pertenecientes a un curso
        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(Interaction.InputBox("Añadir código del curso a borrar"));
            //mostrará los datos de todos los alumnos pertenecientes a ese curso
            //mostrarAlumnosDeCurso(codigo);
        }
    }
}
