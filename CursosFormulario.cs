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
        public ListadeAlumnosClase listadeAlumnosClase;

        public CursosFormulario(ListadeCursosClase listaCursos, ListadeAlumnosClase listadeAlumnosClase)
        {
            InitializeComponent();
            this.listaCursos = listaCursos;
            this.listadeAlumnosClase = listadeAlumnosClase;
        }

        //añadir curso
        private void button1_Click(object sender, EventArgs e)
        {           
            listaCursos.anadirCurso();
        }

        //eliminar curso
        private void button2_Click(object sender, EventArgs e)
        {
            listaCursos.eliminarCurso();
           
        }

        //mostrar todos los cursos
        private void button3_Click(object sender, EventArgs e)
        {
            listaCursos.MostrarCursos();
        }

        //mostrar todos los alumnos pertenecientes a un curso
        private void button4_Click(object sender, EventArgs e)
        {
            listadeAlumnosClase.mostrarAlumnosCurso();

        }
    }
}
