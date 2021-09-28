using System;
using System.Collections.Generic;
using EntidadesM;

namespace DatosM
{
    public class D_Maestro
    {
        List<E_Maestro> ListaMaestros = new List<E_Maestro>(); // Guarda la informacion de los maestros.

        // Retorna un lista de tipo E_Maestro.
        public List<E_Maestro> ListadoMaestros()
        {
            // Si la lista ya tiene datos.
            if (ListaMaestros.Count != 0)
            {
                return ListaMaestros; // Retorna la lista con los datos que tenga.
            }
            else // Si la lista no tiene datos.
            {
                ListaMaestros.Add(new E_Maestro(1, "Wiliiam", "Portillo", 27));   // Posicion [0]
                ListaMaestros.Add(new E_Maestro(2, "Gilma", "Tejada", 35));  // Posicion [1]
                ListaMaestros.Add(new E_Maestro(3, "Alex", "Cardoza", 28));    // Posicion [2]
                ListaMaestros.Add(new E_Maestro(4, "Celina", "Cartagena", 30));  // Posicion [3]
                ListaMaestros.Add(new E_Maestro(5, "Eduardo", "Lemus", 25));    // Posicion [4]

                return ListaMaestros;
            }
        }
    }
}
