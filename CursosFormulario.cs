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
        //He creado esta lista porque no consigo sacar la que viene del formulario inicial
        List<CursoClase> ListadeCursosClaseACambiar = new List<CursoClase>();

        //TODO queda encampsulado y no se puede añadir ni sacar nada de la lista
        private ListadeCursosClase listaCursos;
        public CursosFormulario(ListadeCursosClase listaCursos)
        {
            InitializeComponent();
            this.listaCursos = listaCursos;
        }




        //añadir curso
        private void button1_Click(object sender, EventArgs e)
        {
            //se crea
            CursoClase curso = new CursoClase();
            
            //se pide la información para añadirla
            curso.Codigo = int.Parse(Interaction.InputBox("Código del curso"));
            curso.Nombre = Interaction.InputBox("Nombre del curso");
            ListadeCursosClaseACambiar.Add(curso);

            //TODO no reconoce curso            
            //listaCursos.Add(curso);
        }

        //eliminar curso
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeCursosClaseACambiar por listaCursos cuando se pueda acceder a ella 
            int codigo = int.Parse(Interaction.InputBox("Añadir código del curso a borrar"));
            foreach (var curso in ListadeCursosClaseACambiar)//TODO salta aquí
            {
                if (curso.Codigo == codigo)
                {
                    ListadeCursosClaseACambiar.Remove(curso);
                }
            }
            MessageBox.Show("Curso eliminado");
        }

        //mostrar todos los cursos
        private void button3_Click(object sender, EventArgs e)
        {
            //TODO cambiar ListadeCursosClaseACambiar por listaCursos cuando se pueda acceder a ella 
            string texto = "Cursos";
            foreach (var curso in ListadeCursosClaseACambiar)
            {
                texto += "\n" + curso.Nombre;
            }

            MessageBox.Show(texto);
        }

        //mostrar todos los alumnos pertenecientes a un curso
        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(Interaction.InputBox("Añadir código para ver los alumnos de ese curso"));
            string texto = "Alumnos del curso";

            //TODO cambiar ListadeCursosClaseACambiar por listaCursos cuando se pueda acceder a ella 
            foreach (var curso in ListadeCursosClaseACambiar)
            {
                if (curso.Codigo == codigo)
                {
                    texto += "\n";//¿Alumnos?
                }
                MessageBox.Show(texto);
            }

        }
    }
}
