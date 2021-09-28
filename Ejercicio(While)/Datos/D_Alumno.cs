using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class D_Alumno
    {
        List<E_Alumno> ListaAlumnos = new List<E_Alumno>();

        // Este metodo retorna una lista de tipo E_Alumno.
        public List<E_Alumno> ListadoAlumnos()
        { 
            // Si la lista ya tiene datos.
            if (ListaAlumnos.Count != 0) // ".Cont": Retorna el numero de elmentos que hay en una lista.
            { 
                return ListaAlumnos; // Retorna la lista con los datos que tenga.
            }
            else // Si la lista no tiene datos.
            {
                // Agrega estos datos.
                ListaAlumnos.Add(new E_Alumno(1, "Wilfredo", "Morales", 19, 7.4));   // Posicion [0]
                ListaAlumnos.Add(new E_Alumno(2, "Cristian", "Figueroa", 18, 9.9));  // Posicion [1]
                ListaAlumnos.Add(new E_Alumno(3, "Wilfredo", "Calles", 20, 9.3));    // Posicion [2]
                ListaAlumnos.Add(new E_Alumno(4, "Kimberly", "Amaya", 19, 8.2));     // Posicion [3]
                ListaAlumnos.Add(new E_Alumno(5, "Eduardo", "Vasquez", 18, 7.5));    // Posicion [4]

                return ListaAlumnos;
            }
        }

        // Este metodo recibe un "Alumno" para agregarlo en la lista.
        public void AgregarAlumno(E_Alumno nuevoAlumno)
        {
            ListaAlumnos.Add(nuevoAlumno); // El metodo ".Add()" agrega un elemento a la coleccion (lista).
        }

        // Este metodo recibe a un "Alumno" para editarlo en la lista.
        public void EditarAlumno(E_Alumno editarAlumno)
        {
            // Con este for se recorre cada elemento de la "ListaAlumnos".
            for (int i = 0; i < ListaAlumnos.Count; i++)
            {
                // En cada iteración se compara el Id de la lista con el Id del alumno recibido (editar).
                if (ListaAlumnos[i].Id == editarAlumno.Id)
                { 
                    // Cuando se encuentra el alumno, se reemplaza la vieja informacion por la nueva.
                    ListaAlumnos[i] = editarAlumno;
                }
            }
        }

        // Este metodo elimina un "Alumno" de la "ListaAlumnos".
        public void EliminarAlumno(E_Alumno eliminarAlumno)
        {
            // El metodo ".RemoveAll" busca en la "ListaAlumnos" y cuando encuentra un dato que cumpla con la
            // condicion "r.Id == alumno.Id" y lo borra de la lista.
            ListaAlumnos.RemoveAll(r => r.Id == eliminarAlumno.Id);
        }
    }
}
