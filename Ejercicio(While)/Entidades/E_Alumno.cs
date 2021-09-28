using System;

namespace Entidades
{
    public class E_Alumno
    {
        private int id;
        private String nombre;
        private String apellidos;
        private int edad;
        private double promedio;    

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Promedio { get => promedio; set => promedio = value; }

       public E_Alumno () { }

        public E_Alumno(int id, string nombre, string apellidos, int edad, double promedio)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.promedio = promedio;
        }

        public override string ToString()
        {
            return String.Format("Id: {0}, Nombre: {1}, Apellidos: {2}, Edad: {3}, Promedio: {4}",
                id, nombre, apellidos, edad, promedio);
        }
    }
}
