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

                Console.WriteLine("\tHistòria");

                // Pregunta 1
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

                /*********************************************************************************************/
                // Pregunta 3
                Console.WriteLine("\n\t3. Qui va ser el primer president dels Estats Units?");
                Console.WriteLine("\n\n\ta. George Washington");
                Console.WriteLine("\tb. John Adams");
                Console.WriteLine("\tc. Theodore Roosevelt");
                Console.WriteLine("\td. James Madison");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 4
                Console.WriteLine("\n\t4. En quin any es va crear l'Organització de les Nacions Unides?");
                Console.WriteLine("\n\n\ta. 1945");
                Console.WriteLine("\tb. 1946");
                Console.WriteLine("\tc. 1947");
                Console.WriteLine("\td. 1948");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 5
                Console.WriteLine("\n\t5. Què caravel·la no va tornar de el viatge en el qual Colom va arribar a Amèrica per primera vegada?");
                Console.WriteLine("\n\n\ta. Santa María");
                Console.WriteLine("\tb. Santa Lucía");
                Console.WriteLine("\tc. Santa Ana");
                Console.WriteLine("\td. Santa Adriana");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

            } else if (opcio == 2) {

                // Pregunta 1
                Console.WriteLine("\tArt i literatura");
                Console.WriteLine("\n\t1. Qui va escriure la Ilíada i l'Odissea?");
                Console.WriteLine("\n\n\ta. Homer");
                Console.WriteLine("\tb. Sòcrates");
                Console.WriteLine("\tc. Plató");
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
                Console.WriteLine("\n\t2. Qui va pintar el Guernica?");
                Console.WriteLine("\n\n\ta. Pablo Ruiz Picasso");
                Console.WriteLine("\tb. Salvador Dalí");
                Console.WriteLine("\tc. Joan Miró");
                Console.WriteLine("\td. Cap de les anteriors");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 3
                Console.WriteLine("\n\t3. Quin altre idioma, a més del castellà, va escriure la novel·lista i poetessa Rosalía de Castro?");
                Console.WriteLine("\n\n\ta. Català");
                Console.WriteLine("\tb. Gallec");
                Console.WriteLine("\tc. Anglès");
                Console.WriteLine("\td. Xinès");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "b") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");


                /*********************************************************************************************/
                // Pregunta 4
                Console.WriteLine("\n\t4. Quin nom tenia el cavall de Don Quixot de la Manxa?");
                Console.WriteLine("\n\n\ta. Alberto");
                Console.WriteLine("\tb. Rocinante");
                Console.WriteLine("\tc. Juanjo");
                Console.WriteLine("\td. Vago");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "b") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 5
                Console.WriteLine("\n\t5. Quin personatge de l'univers literari de Harry Potter té una rata anomenada Scabbers?");
                Console.WriteLine("\n\n\ta. Snape");
                Console.WriteLine("\tb. Harry Potter");
                Console.WriteLine("\tc. Dumbledore");
                Console.WriteLine("\td. Ron Weasley");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "d") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

            } else {

                // Pregunta 1
                Console.WriteLine("\tNaturalesa y ciències");
                Console.WriteLine("\n\t1. Quina és la velocitat de la llum?");
                Console.WriteLine("\n\n\ta. 299.792.458 km/s");
                Console.WriteLine("\tb. 299.792.450 km/s");
                Console.WriteLine("\tc. 299.792.457 km/s");
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
                Console.WriteLine("\n\t2. Quin és l'au de major envergadura que segueix viva actualment?");
                Console.WriteLine("\n\n\ta. L'albatros.");
                Console.WriteLine("\tb. El colibrí");
                Console.WriteLine("\tc. L'àliga real");
                Console.WriteLine("\td. El voltó");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 3
                Console.WriteLine("\n\t3. Quines són les bases nitrogenades de l'ADN?");
                Console.WriteLine("\n\n\ta. Són la guanina, l'adenina, la timina i la citosina.");
                Console.WriteLine("\tb. Són la guanina, la timina i la citosina.");
                Console.WriteLine("\tc. Són la guanina, l'adenina i la citosina.");
                Console.WriteLine("\td. Són l'adenina, la timina i la citosina.");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 4
                Console.WriteLine("\n\t4. Al voltant de quin planeta orbiten els satèl·lits Ganímedes, Calisto, Io i Europa?");
                Console.WriteLine("\n\n\ta. Saturn");
                Console.WriteLine("\tb. Mercuri");
                Console.WriteLine("\tc. Júpiter");
                Console.WriteLine("\td. Venus");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "c") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");

                /*********************************************************************************************/
                // Pregunta 5
                Console.WriteLine("\n\t5. Per què va ser famosa Marie Curie?");
                Console.WriteLine("\n\n\ta. Marie Curie és especialment coneguda pel descobriment de la radioactivitat");
                Console.WriteLine("\tb. Marie Curie és especialment coneguda pel descobriment de la gravetat");
                Console.WriteLine("\tc. Marie Curie és especialment coneguda pel descobriment de la velocitat de llum");
                Console.WriteLine("\td. Marie Curie és especialment coneguda pel descobriment dels forats negres");

                test = Console.ReadLine();

                while (test != "a" && test != "b" && test != "c" && test != "d") {
                    Console.Write("\n\tEscriu opció: ");
                    test = Console.ReadLine();
                }

                if (test == "a") Console.WriteLine("\tOpcio Correcte!");
                else Console.WriteLine("\tOpcio Incorrecte!");
            }

                // Mostrar fi del programa
                Console.Write("\n\tFi del Joc de Preguntes");
        }
    }
}
