using System;

namespace TutNov15
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] c = new int[3];
            // 45 57 6
            // 0  1  2 | 3
            
            #region Arrays
            int note1 = 3;
            int note2 = 1;
            int note3 = 6;
            int note4 = 2;
            int note5 = 1;

            /*
            int[] noten = new int[5];

            noten[0] = 3;
            noten[1] = 1;
            noten[2] = 6;
            noten[3] = 2;
            noten[4] = 1;
            */
                
            //             0  1  2  3  4  | (5)
            int[] noten = {3, 1, 6, 2, 1};
            //             5  4  3  2  1  <- (nur bei ^)
            
            // Fehler weil out of bounds >:(
            // Console.WriteLine(noten[5]);

            // Letztes Element im Array
            Console.WriteLine(noten[noten.Length - 1]);
            // i = i + 1 -> i += 1 -> i++
            Console.WriteLine(noten[^1]); // ^ und dann Index -> von hinten zählen (aber nicht 0-indexed)
            
            Console.WriteLine(noten[^3] == noten[2]); // TRUE -> gleiches Element

            int[] b = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //   b =^= {1, 4, 9, 16, 25, 36, 49, 64, 81}

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = b[i] * b[i]; // hoch 2
                // Math.Pow(i, 2);
            }

            Ausgeben(b);
            Console.WriteLine(b); // [1, 2, 3, 4, 5] das nicht!

            Console.WriteLine("FOREACH -----");
            // Problem mit foreach: kein Index -> b[i] funktioniert nicht
            foreach (int element in b) // "black magic"
            {
                Console.WriteLine(element);
            }

            // Ausgeben(noten);
            #endregion

            #region 2D Arrays
            // Tic Tac Toe
            /*
             x x x row1
             x x x row2
             x x x row3
             */
            
            string[] row1 = new string[3];
            string[] row2 = new string[3];
            string[] row3 = new string[3];
            
            // 2D Arrays!!!
            string[,] rows = new string[3,3];

            // new string[x, y]
            // x = reihen
            // y = spalten !!!!
            
            string[,] rowsFilled =
            {
                //0    1    2
                {"x", "-", "o"}, // 0
                {"-", "x", "o"}, // 1
                {"x", "-", "o"}, // 2
            };
            
            // rowsFilled[0, 1] -> -
            
            // string[,]  COOL
            // string[][] BÖSE ausgefranst (Unterarrays nicht immer gleich lang)
            #endregion

        }

        public static void Ausgeben(int[] array)
        {
            /*
            //          i < length ODER i <= length - 1
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            */
            
                // hier foreach passend!
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
            
            Ausgeben(array);
        }

        // Ausgeben 2D Array: nächstes mal mehr
        public static void Ausgeben2(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // Gibt eine Reihe aus
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                
                Console.WriteLine(); // Leerzeile
            }
        }
    }
}