using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public class ListadeCursosClase
    {
        private List<CursoClase> listaCursos;
        public ListadeCursosClase()
        {
            listaCursos = new List<CursoClase>();
        }
        public void anadirCurso()
        {
            try
            {
                string nombre = Interaction.InputBox("Añadir nombre del curso");
                int codigo = int.Parse(Interaction.InputBox("Añadir código del curso"));
                CursoClase curso = new CursoClase(codigo, nombre);
                listaCursos.Add(curso);
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto " + fEx);
            }
        }

        public void eliminarCurso()
        {
            try
            {

                int codigo = int.Parse(Interaction.InputBox("Añadir código del curso a borrar"));

                bool encontrado = false;
                if(listaCursos.Count > 0)
                {

                    foreach(var curso in listaCursos)
                    {
                        if(curso.Codigo == codigo)
                        {
                            listaCursos.Remove(curso);
                            MessageBox.Show("Curso eliminado");
                            encontrado = true;
                            break;
                        }
                    }
                    if(!encontrado) { MessageBox.Show("Curso no encontrado"); }
                }
                else
                {
                    MessageBox.Show("No tiene cursos");
                }


            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }
        }

        public void MostrarCursos()
        {
            try
            {

                string texto = "";
                if(listaCursos.Count > 0)
                {
                    texto += "Cursos:";
                    foreach(var curso in listaCursos)
                    {

                        texto += "\n" + curso.mostrarCurso();
                    }
                }
                else
                {
                    texto = "No tiene ningún curso en la lista";
                }
                MessageBox.Show(texto);
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }
        }
    }





}
