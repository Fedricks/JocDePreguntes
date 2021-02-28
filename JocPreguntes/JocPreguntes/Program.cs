﻿using System;

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

            if (opcio == 1) {

                // Pregunta 1
                Console.WriteLine("\tHistòria");
                Console.WriteLine("\n\t1. Qui va ser el primer president de la democràcia espanyola després del franquisme?");
                Console.WriteLine("\n\n\ta. Adolfo Suárez");
                Console.WriteLine("\tb. José Mariano Rajoy");
                Console.WriteLine("\tc. Pedro Sánchez");
                Console.WriteLine("\td. Cap de les anteriors");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 2
                Console.WriteLine("\n\t2. En quin any l'home va trepitjar la Lluna per primera vegada?");
                Console.WriteLine("\n\n\ta. 1967");
                Console.WriteLine("\tb. 1968");
                Console.WriteLine("\tc. 1969");
                Console.WriteLine("\td. 1970");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "c") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");
            }

                // Mostrar fi del programa
                Console.Write("\n\tFi del Joc de Preguntes");
        }
    }
}
