using System;

namespace JocPreguntes {
    class Program {
        static void Main(string[] args) {
            // Declaració de variables
            int opcio;
            string test;

            // Mostrar Menú temes per consola
            Console.WriteLine("\t\tJoc de Preguntes\n");
            Console.WriteLine("\t1. Història");
            Console.WriteLine("\t2. Art i literatura");
            Console.WriteLine("\t3. Naturalesa y ciències");

            // Mostrar Menú temes per consola
            Console.Write("\n\tEscriu opció: ");
            opcio = int.Parse(Console.ReadLine());

            while (!(opcio >= 1 && opcio <= 3)) {
                Console.Write("\n\tEscriu opció: ");
                opcio = int.Parse(Console.ReadLine());
            }

            // Borrar Consola
            Console.Clear();

            
            // Mostrar fi del programa
            Console.Write("\n\tFi del Joc de Preguntes");
        }
    }
}
