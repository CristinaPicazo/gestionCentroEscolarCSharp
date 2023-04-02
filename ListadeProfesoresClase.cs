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
    public class ListadeProfesoresClase
    {
        private List<ProfesorClase> listadeProfesores;

        public ListadeProfesoresClase()
        {
            listadeProfesores = new List<ProfesorClase>();
        }

        public bool estaListaProfesoresVacia()
        {
            bool listaVacia = true;
            if(listadeProfesores.Count > 0) return listaVacia = false;
            MessageBox.Show("No tiene profesores");
            return listaVacia;
        }

        public bool profesorEncontrado(string datoProfesor)
        {
            bool encontrado = false;
            foreach(var profesor in listadeProfesores)
            {
                if(profesor.Nombre == datoProfesor || profesor.Dni == datoProfesor)
                {
                    return encontrado = true;
                }
            }
            MessageBox.Show("Profesor no encontrado");
            return encontrado;
        }

        public void anadirProfesor()
        {
            try
            {
                string nombre = Interaction.InputBox("Nombre del profesor:");
                string dni = Interaction.InputBox("DNI del profesor:");
                string telefono = Interaction.InputBox("Telefono del profesor:");
                int codigoCurso = int.Parse(Interaction.InputBox("Codigo del curso del profesor:"));

                ProfesorClase profesor = new ProfesorClase(nombre, dni, telefono, codigoCurso);
                listadeProfesores.Add(profesor);
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }
        }

        public void eliminarProfesor()
        {
            if(!estaListaProfesoresVacia())
            {
                string nombre = Interaction.InputBox("Nombre del profesor:");
                if(profesorEncontrado(nombre))
                {
                    foreach(var profesor in listadeProfesores)
                    {
                        if(profesor.Nombre == nombre)
                        {
                            listadeProfesores.Remove(profesor);
                            MessageBox.Show("Profesor eliminado");
                            break;
                        }
                    }
                }
            }
        }
        public void mostrarListaProfesores()
        {
            try
            {
                if(!estaListaProfesoresVacia())
                {
                    string texto = "Lista de profesores:";
                    foreach(var profesor in listadeProfesores)
                    {
                        texto += "\n\t" + profesor.Nombre;
                    }
                    MessageBox.Show(texto);
                }
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }

        }

        public void ordenarProfesores()
        {
            try
            {
                if(!estaListaProfesoresVacia())
                {
                    listadeProfesores.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
                    MessageBox.Show("Lista ordenada");
                }
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }

        }
        public void mostrarDatosProfesores()
        {
            try
            {


                if(!estaListaProfesoresVacia())
                {
                    string nombre = Interaction.InputBox("Nombre del profesor:");
                    if(profesorEncontrado(nombre))
                    {
                        foreach(var profesor in listadeProfesores)
                        {
                            if(profesor.Nombre == nombre)
                            {
                                profesor.datosProfesor();
                            }
                        }
                    }
                }
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }
        }

        public void anadirAsignaturaAProfesor()
        {
            try
            {
                string dni = Interaction.InputBox("Introduce el DNI el profesor");
                if(profesorEncontrado(dni))
                {
                    foreach(var profesor in listadeProfesores)
                    {
                        if(profesor.Dni == dni)
                        {
                            profesor.anadirAsignatura();
                        }
                    }
                }
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }

        }

        public void eliminarAsignaturaAProfesor()
        {
            try
            {
                string dni = Interaction.InputBox("Introduce el DNI el profesor");
                if(profesorEncontrado(dni))
                {
                    foreach(var profesor in listadeProfesores)
                    {
                        if(profesor.Dni == dni)
                        {
                            profesor.eliminarAsignaturas();
                        }
                    }
                }
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }
        }

        public void mostrarProfesorPorAsignatura()
        {
            try
            {

                if(!estaListaProfesoresVacia())
                {
                    string nombreAsignatura = Interaction.InputBox("Introduce el nombre de la asignatura");
                    string texto = "La asignatura " + nombreAsignatura + " la imparten los profesores: ";
                    bool existeAsignatura = false;

                    foreach(var profesor in listadeProfesores)
                    {
                        if(profesor.imparteAsignatura(nombreAsignatura))
                        {
                            texto += "\n\t" + profesor.Nombre;
                            existeAsignatura = true;
                        }
                    }
                    if(!existeAsignatura)
                    {
                        texto = "Esa asignatura no existe";
                    }
                    MessageBox.Show(texto);

                }
            }
            catch(FormatException fEx)
            {
                MessageBox.Show("Formato no correcto" + fEx);
            }
        }

    }
}
