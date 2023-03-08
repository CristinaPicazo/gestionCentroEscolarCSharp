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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Creamos la lista de cursos.
        ListadeCursosClase listaCursos = new ListadeCursosClase();
        // Crear aquí también la lista de profesores y de alumnos.
        ListadeProfesoresClase listaProfesores = new ListadeProfesoresClase();
        ListadeAlumnosClase listaAlumnos = new ListadeAlumnosClase();

        //gestión cursos
        private void button1_Click(object sender, EventArgs e)
        {
            // Creamos el formulario pasándole la lista de cursos creada en este...
            CursosFormulario cursosFormulario = new CursosFormulario(listaCursos);
            // Aquí mostramos el formulario, que ya tendrá la lista de cursos.
            cursosFormulario.ShowDialog();
        }

        //gestión profesores
        private void button2_Click(object sender, EventArgs e)
        {
            ProfesoresFormulario profesoresFormulario = new ProfesoresFormulario(listaProfesores);
            profesoresFormulario.ShowDialog();

        }

        //gestión alumnos
        private void button3_Click(object sender, EventArgs e)
        {
            AlumnosFormulario alumnosFormulario = new AlumnosFormulario(listaAlumnos);
            alumnosFormulario.ShowDialog();

        }
    }
}
