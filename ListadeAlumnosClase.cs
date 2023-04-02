using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public class ListadeAlumnosClase
    {

        private List<AlumnoClase> listaAlumnos;
        public ListadeAlumnosClase()
        {
            listaAlumnos = new List<AlumnoClase>();
        }

        public bool estaListaAlumnosVacia()
        {
            bool listaVacia = true;
            if(listaAlumnos.Count > 0) return listaVacia = false;
            MessageBox.Show("No tiene alumnos");
            return listaVacia;
        }
        
        public bool alumnoEncontrado(string datoAlumno){
            bool encontrado = false;
            foreach(var alumno in listaAlumnos)
            {
                if(alumno.Nombre == datoAlumno || alumno.Dni == datoAlumno)
                {
                    return encontrado = true;
                }
            }
            MessageBox.Show("Alumno no encontrado");
            return encontrado;
        }

        public void anadirAlumno()
        {
            string nombre = Interaction.InputBox("Nombre del alumno:");
            string dni = Interaction.InputBox("DNI del alumno:");
            string telefono = Interaction.InputBox("Telefono del alumno:");
            int codigoCurso = int.Parse(Interaction.InputBox("Codigo del curso del alumno:"));

            AlumnoClase alumno = new AlumnoClase(nombre, dni, telefono, codigoCurso);
            listaAlumnos.Add(alumno);
        }

        public void eliminarAlumno()
        {
            if(!estaListaAlumnosVacia())
            {
                string nombre = Interaction.InputBox("Nombre del alumno:");
                if(alumnoEncontrado(nombre))
                {
                    foreach(var alumno in listaAlumnos)
                    {
                        if(alumno.Nombre == nombre)
                        {
                            listaAlumnos.Remove(alumno);
                            MessageBox.Show("Alumno eliminado");
                            break;
                        }
                    }
                }
            }
        }
        public void mostrarListaAlumnos()
        {
            if(!estaListaAlumnosVacia())
            {
                string texto = "Lista de alumnos:";
                foreach(var alumno in listaAlumnos)
                {
                    texto += "\n\t" + alumno.Nombre;
                }
                MessageBox.Show(texto);
            }

        }

        public void mostrarAlumnosCurso()
        {
            if(!estaListaAlumnosVacia())
            {
                int curso = int.Parse(Interaction.InputBox("Codigo del curso:"));
                bool encontrado = false;
                string texto = "Alumnos del curso: ";
               
                    foreach(var alumno in listaAlumnos)
                    {
                        if(alumno.CodigoCurso == curso)
                        {
                            texto += "\n\t"+alumno.Nombre;
                            encontrado = true;
                        }
                    }
                if(!encontrado)
                {
                    texto = "Curso no encontrado o sin alumnos";
                }
                MessageBox.Show(texto);
            }            
        }        

        public void ordenarAlumnos()
        {
            if(!estaListaAlumnosVacia())
            {
                listaAlumnos.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            }
            
        }
        public void mostrarDatosNombre()
        {
            if(!estaListaAlumnosVacia())
            {
                string nombre = Interaction.InputBox("Nombre del alumno:");
                if(alumnoEncontrado(nombre))
                {
                    foreach(var alumno in listaAlumnos)
                    {
                        if(alumno.Nombre == nombre)
                        {
                            alumno.datosAlumno();
                        }
                    }
                }                
            }
        }

        public void anadirNotasAlumno()
        {
            string dni = Interaction.InputBox("Introduce el dni el alumno");
            if(alumnoEncontrado(dni))
            {
                foreach(var alumno in listaAlumnos)
                {
                    if(alumno.Dni == dni)
                    {
                        alumno.anadirNotas();
                    }
                }
            }

        }

        public void eliminarNotasAlumno()
        {
            string dni = Interaction.InputBox("Introduce el dni el alumno");
            if(alumnoEncontrado(dni))
            {
                foreach(var alumno in listaAlumnos)
                {
                    if(alumno.Dni == dni)
                    {
                        alumno.eliminarNotas();
                    }
                }
            }
        }

        public void notasMayorCinco()
        {
            if(!estaListaAlumnosVacia())
            {
                string texto = "Alumnos con nota mayor de 5:";
                bool sinAlumnos = true;
                foreach(var alumno in listaAlumnos)
                {
                    if(alumno.ListaNotasMayorCinco() != "")
                    {
                        texto += alumno.ListaNotasMayorCinco();
                        sinAlumnos = false;
                    }
                }
                if(sinAlumnos)
                {
                    texto = "Ningún alumno tiene la nota media superior de 5";
                }
                MessageBox.Show(texto);
            }
        }

        public void notasMenorCinco()
        {
            if(!estaListaAlumnosVacia())
            {
                string texto = "Alumnos con nota menor de 5:";
                bool sinAlumnos = true;
                foreach(var alumno in listaAlumnos)
                {
                    if(alumno.ListaNotasMenorCinco() != "")
                    {
                        texto += alumno.ListaNotasMenorCinco();
                        sinAlumnos = false;
                    }
                }
                if(sinAlumnos)
                {
                    texto = "Ningún alumno tiene la nota media menor de 5";
                }
                MessageBox.Show(texto);
            }
        }

    }
}
