using System;

public class Persona
{

        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    

    // Uso de la clase
    class Program
    {
        static void Main()
        {
            Persona persona1 = new Persona("Juan", 30);
            persona1.MostrarInformacion();
        }
    }

}

