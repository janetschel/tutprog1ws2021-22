using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main1(string[] args)
        {
            // do-while
            int input;
            do
            {
                Console.Write("Zahl zwischen 10 und 20: ");
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < 10 || input > 20);

            
            // while
            bool hatEingabeGemacht = false;
            while (hatEingabeGemacht == false || input < 10 || input > 20)
            {
                Console.Write("Zahl zwischen 10 und 20: ");
                input = Convert.ToInt32(Console.ReadLine());
                hatEingabeGemacht = true;
            }
            
            
            // for-schleifen
            // for (anfangswert; überprüfung; inkrement)
            int inputFor;
            for (bool eingabeGemacht = false; eingabeGemacht == false || input < 10 || input > 20; eingabeGemacht = true)
            {
                Console.Write("Zahl zwischen 10 und 20: ");
                inputFor = Convert.ToInt32(Console.ReadLine());
            }
            
            // for (int i = 0, j = 1; i < 10 && j > 1; i++, j--)

            // while cool
            int inputB = Convert.ToInt32(Console.ReadLine());
            while (inputB < 10 || inputB > 20)
            {
                Console.Write("Zahl zwischen 10 und 20: ");
                inputB = Convert.ToInt32(Console.ReadLine());
            }
            
            // bool
            bool a = true;
            bool b = true;
            bool c = false;

            bool result = a || b || c; // true oder true oder false
            result = a && b && c;
            // a && b
            // b && a
        }
    }
}