using System;
using System.Collections.Generic;
using Entidades;
using Negocios;
using EntidadesM;
using NegociosM;

namespace Vistas
{
    class View
    {
        static void Main(string[] args)
        {
            // Objetos para consultar la capa de negocios, mostrar la Lista de Alumnos y enviar los datos del Alumno para
            // agregar, editar y eliminar.

            N_Alumno negocios = new N_Alumno();
            List<E_Alumno> listado = negocios.N_ListaAlumnos();
            E_Alumno alumno = new E_Alumno();

            N_Maestro negocio = new N_Maestro();
            List<E_Maestro> listado2 = negocio.N_ListadoMaestros();

            // Variable para detener o continuar el bucle While y saber que opción eligió el usuario.
            int opcion = 1;

            // BUCLE WHILE
            while (opcion != 0)
            {
                // Menu de opciones que tiene el usuario.
                Console.WriteLine("************ MENÚ ************" +
                    "\n1-Ver lista de alumnos." +
                    "\n2-Agregar un nuevo alumno." +
                    "\n3-Editar un alumno existente." +
                    "\n4-Eliminar un alumno existente." +
                    "\n5-Ver lista de maestros." +
                    "\n0-Salir del sistema.");
                opcion = int.Parse(Console.ReadLine());

                // "Limpiamos" la informacion del objeto alumno.
                alumno = new E_Alumno();

                switch (opcion)
                {
                    // Caso 1: Muestra la lista de alumnos.
                    case 1:
                        Console.WriteLine("************ LISTA DE ALUMNOS ************");

                        // Este foreach nos recorre la lista y nos muestra cada alumno.
                        foreach (E_Alumno item in listado) // item = variable; collection = lista
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n");
                        break;

                    // Caso 2: Registra un nuevo alumno.
                    case 2:
                        Console.WriteLine("************ REGISTRANDO NUEVO ALUMNO ************");

                        // Consiguiendo nuevo Id.
                        E_Alumno nuevoId = listado[listado.Count - 1];
                        alumno.Id = (nuevoId.Id + 1);

                        // Pedimos los datos del nuevo alumno.
                        Console.WriteLine("Nombres: ");
                        alumno.Nombre = Console.ReadLine();

                        Console.WriteLine("Apellidos: ");
                        alumno.Apellidos = Console.ReadLine();

                        Console.WriteLine("Edad: ");
                        alumno.Edad = int.Parse(Console.ReadLine());

                        // Pedimos a la capa de negocios que nos agregue el alumno.
                        negocios.N_AgregarAlumno(alumno);

                        Console.WriteLine("Procesando....." +
                            "\nAgregando....." +
                            "\n¡Alumno registrado con éxito!");
                        Console.WriteLine("\n\n");
                        break;

                    // Caso 3: Edita la información de un alumno.
                    case 3:
                        Console.WriteLine("************ EDITANDO ALUMNO ************");

                        // Para editar un alumno necesitamos su Id para buscarlo en la lista.
                        Console.WriteLine("Id:");
                        alumno.Id = int.Parse(Console.ReadLine());

                        // Luego pedimos los datos que se quieren editar.
                        Console.WriteLine("Nombres: ");
                        alumno.Nombre = Console.ReadLine();

                        Console.WriteLine("Apellidos: ");
                        alumno.Apellidos = Console.ReadLine();

                        Console.WriteLine("Edad: ");
                        alumno.Edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Promedio: ");
                        alumno.Promedio = double.Parse(Console.ReadLine());

                        // Pedimos a la capa de negocios que nos edite el alumno.
                        negocios.N_EditarAlumno(alumno);

                        Console.WriteLine("Procesando....." +
                            "\nEditando....." +
                            "\n¡Alumno editado con éxito!");
                        Console.WriteLine("\n\n");
                        break;

                    //Caso 4: Elimina aun alumno.
                    case 4:
                        Console.WriteLine("************ ELIMINANDO ALUMNO ************");
                        //Para eliminar una persona nos basta con saber su Isd, asi que lo solicitamos.

                        Console.WriteLine("Id: ");
                        alumno.Id = int.Parse(Console.ReadLine());

                        // Pedimos a la capa de negocios que nos elimine la persona.
                        negocios.N_EliminarAlumno(alumno);
                        Console.WriteLine("Procesando....." +
                            "\nEliminando....." +
                            "\n¡Alumno eliminado con éxito!");
                        Console.WriteLine("\n\n");
                        break;

                    // Caso 5: Muestra la lista de profesores.
                    case 5:
                        Console.WriteLine("************ LISTA DE MAESTROS ************");

                        // Este foreach nos recorre la lista y nos muestra cada alumno.
                        foreach (E_Maestro item in listado2)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n");
                        break;

                    //Caso 0: Para salir del bucle y que termine el programa.
                    case 0:
                        Console.WriteLine("¡Bye!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}