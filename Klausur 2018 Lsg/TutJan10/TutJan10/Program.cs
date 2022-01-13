using System;

namespace TutJan10
{
    class Program
    {

        static void Minima(int[] min)
        {
            for (int i = 1; i < min.Length - 1; i++)
            {
                if (min[i - 1] > min[i] && min[i + 1] > min[i])
                {
                    Console.WriteLine(min[i]);
                }
            }
        }

        static string Addiere(string zahl1, string zahl2)
        {
            string summe = "";
            int uebertrag = 0;
            
            // "42" + "29" = "71"
            for (int i = zahl1.Length - 1; i >= 0; i--)
            {
                char ziffer1 = zahl1[i];
                char ziffer2 = zahl2[i];

                int zwischenergebnis = ziffer1 + ziffer2 - 96 + uebertrag;
                // 11 % 10 = 1 -> Einsersteller einer Zahl (was wir hinschreiben)
                // 3 % 10 = 3 -> 3 / 10 -> 0.3 -> 0
                // 219 % 10 = 9 -> 219 : 10 = 21 R 9
                
                // 219 / 10 = 21.9 -> 21|.9 -> 21
                
                summe = (zwischenergebnis % 10) + summe; // Einserstelle
                uebertrag = zwischenergebnis / 10; // Alles, bis auf Einserstelle NUR BEI INT
            }

            // 2 + 3 = 0(<-- nein)5 
            if (uebertrag != 0)
            {
                summe = uebertrag + summe; // (9)[12312313234456]
            }
            
            /*
             * summe += 1;          Hinten hin
             * summe = summe + 1;
             *
             * summe = 1 + summe    Vorne hin
             */
            
            return summe;
        }
    }
}