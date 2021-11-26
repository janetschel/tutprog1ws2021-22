using System;

namespace TutNov22
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Shadowing
            int a = 6;
            int b = 5;
            int result = Add(a, b);

            double c = 4.5;
            double d = 14.5;
            Add(c, d);
            
            Console.WriteLine(result);
            #endregion

            #region ref
            int eins = 1; 
            int zwei = 2; 
            
            Increment(ref eins, ref zwei);
            
            // eins = 2
            // zwei = 3
            Console.WriteLine(eins);
            Console.WriteLine(zwei);
            #endregion

            #region out u. Unterschied zu ref
            int var;
            int var1;
            // Out(ref var)
            Out(out var, out var1);
            
            // out und ref beides pass by reference
            
            // Einziger Unterschied zw. out und ref
            // Bei ref MUSS eine Variable ein Wert haben (int a =(!) 3;)
            // Bei out NICHT (int a;)
            
            // Wann ref wann out?
            // Wenn Variable einen Wert hat -> immer ref
            // Wenn keine dann immer out
            
            // Durch out signalisiere ich, dass die Methode die Zuweisung eines Wertes übernimmt

            // Use-Case zu out:
            string update;
            int version;
            GetUserInput(out update, out version);
            
            // Wenn nur ein return wert: Hände weg von ref/out!
            #endregion

            #region Beispiel pass by reference
            int input = 1;

            Console.WriteLine("BEFORE -------");
            Console.WriteLine(input);
            Inc(ref input);
            Console.WriteLine("AFTER -------");
            Console.WriteLine(input);
            #endregion
            
            
        }

        #region Beispiel pass by reference
        public static void Inc(ref int input)
        {
            input++; // input += 1;
        }
        #endregion

        #region out
        public static void GetUserInput(out string update, out int version)
        {
            update = Console.ReadLine(); // Fehlerbehebung? Nur Y oder N
            version = Convert.ToInt32(Console.ReadLine());
        }

        public static void Out(out int var, out int var1)
        {
            var = 2;
            var1 = 23;
        }
        #endregion

        #region ref
        // ref benutzen bei mehreren returns
        public static void Increment(ref int eins, ref int zwei)
        {
            eins += 1;
            zwei += 1;
        }
        #endregion

        #region Shadowing
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            
            // return a + b;
        }
        #endregion
    }
}