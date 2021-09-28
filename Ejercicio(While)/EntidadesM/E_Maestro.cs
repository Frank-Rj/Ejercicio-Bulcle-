using System;

namespace EntidadesM
{
    public class E_Maestro
    {
        private int id;
        private String nombre;
        private String apellidos;
        private int edad;


        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }

        public E_Maestro() { }

        public E_Maestro(int id, string nombre, string apellidos, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Nombre: {1}, Apellidos: {2}, Edad: {3}", id, nombre, apellidos, edad);
        }
    }
}
