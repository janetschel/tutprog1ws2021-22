using System;

namespace ConsoleApp
{
    public class Program1
    {
        /*
         * Aufgabe 4 -
         * Gerade oder ungerade?
         *
         * Schreiben  Sie  ein  C#-Programm,  das  alle  geraden/ungeraden  Zahlen  im  Intervall[1,100] auf der Konsole
         * ausgibt.
         * Der Benutzer soll dabei zwischen beiden Möglichkei-ten w ̈ahlen k ̈onnen.
         * M ̈oglicher Programmablauf:
         *
         * M ̈ochten Sie alle geraden (G) oder ungeraden (U) Zahlen zwischen 1 und 100 ausgeben?
         * G
         * Gerade Zahlen:2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56
         * 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98 100
         */
        
        public static void Main(string[] args)
        {
            string input; // G oder U

            // Fehlerbehandlung
            do
            {
                Console.Write("Gerade oder ungerade Zahlen?: ");
                input = Console.ReadLine();
            } while (input != "G" && input != "U"); // nicht gewünschter Fall als Bedingung für Schleife!
            // !(input == "G" || input == "U")
            
            // a == x || a == y -> negativ machen
            // a != x && a != y
            // !(a == x || a == y)

            #region Lösung 1
            switch (input)
            {
                case "G":
                    for (int i = 1; i <= 100; i++)
                    {
                        if (i % 2 == 0)  // 10 : 2 = x R0  -> Rest entweder 0 oder 1
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case "U":
                    for (int i = 1; i <= 100; i++)
                    {
                        // i % 2 != 0
                        if (i % 2 == 1)  // 10 : 2 = x R0  -> Rest entweder 0 oder 1
                        {
                            Console.WriteLine(i);
                        }
                    }
                    break;
            }
            #endregion

            #region Lösung 2
            int remainder;

            if (input == "G")
                remainder = 0;
            else
                remainder = 1;
                    
            
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == remainder)  // 10 : 2 = x R0  -> Rest entweder 0 oder 1
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Lösung ohne If
            int start;

            if (input == "G")
                start = 2;
            else
                start = 1;
            
            for (int i = start; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            
            // 2 4 6 ...
            // 1 3 5 ...
            #endregion
        }
    }
}