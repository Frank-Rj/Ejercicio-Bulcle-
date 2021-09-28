using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace Negocios
{
    public class N_Alumno
    {
         D_Alumno datos = new D_Alumno();

        // Este metodo nos trae la lista de "Alumnos" que se encuentra en la capa de datos.
        public List<E_Alumno> N_ListaAlumnos()
        {
            // Con el objeto "datos" invocamos el metodo que nos devuelve la lista.
            List<E_Alumno> lista = datos.ListadoAlumnos();
            return lista;
        }

        // Este metodo recibe un objeto de tipo "E_Alumno" para enviarlo a la capa de datos y registrarlo.
        public void N_AgregarAlumno(E_Alumno nuevoAlumno)
        {
            // Con el objeto "datos" invocamos el metodo que nos permite agregar el Alumno a la lista.
            nuevoAlumno.Promedio = 0;
            datos.AgregarAlumno(nuevoAlumno);
        }

        // Este metodo recibe un objeto de tipo "E_Alumno" para enviarlo a la capa de datos y actualizarlo.
        public void N_EditarAlumno(E_Alumno editarAlumno)
        {
            // Con el objeto "datos" invocamos el metodo que nos permite editar el alumno.
            datos.EditarAlumno(editarAlumno);
        }

        // Este metodo recibe un objeto tipo E_Persona para enviarlo a la capa de datos y eliminarlo.
        public void N_EliminarAlumno(E_Alumno eliminarAlumno)
        {
            // Con el objeto "datos" invocamos el metodo que nos permite eliminar el alumno.
            datos.EliminarAlumno(eliminarAlumno);
        }
    }
}
