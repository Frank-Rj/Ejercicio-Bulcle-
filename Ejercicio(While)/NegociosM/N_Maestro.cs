using System;
using System.Collections.Generic;
using DatosM;
using EntidadesM;

namespace NegociosM
{
    public class N_Maestro
    {
        D_Maestro datos = new D_Maestro();

        // Trae la lista de Maestros que esta la capa de DatosM.
        public  List<E_Maestro> N_ListadoMaestros()
        {
            List<E_Maestro> lista1 = datos.ListadoMaestros();
            return lista1;
        }
    }
}
