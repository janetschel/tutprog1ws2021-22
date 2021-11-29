using System;
using System.IO;

namespace TutNov29
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pfad = "/Volumes/Externe Daten/Tutorium/ConsoleApp1/TutNov29/TutNov29/daten.txt";
            
            #region Einfache Variante: Lesen
            string text = File.ReadAllText(pfad);

            // Split trennt string an seperator char
            // .Split() macht aus ganzem Text einzelne Zeilen 
            /*
             * "Hallo", "Welt", "3434"
             *    0       1       2
             */          

            string[] zeilen = text.Split("\n");
            
            // Ausgeben auf der Console:
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{i}: {zeilen[i]}");
            }

            // damit spar ich .Split()
            // kein Problem in Klausur:
            string[] zeilen1 = File.ReadAllLines(pfad);
            #endregion

            #region Doofe Variante: Lesen
            // Datentyp Name = new StreamReader(pfad); 
            StreamReader sr = new StreamReader(pfad);

            /*
            // lese Zeile aus Datei daten.txt
            // sr.ReadLine() "konsumiert" die Zeile: lesen -> in variable speichern -> dann "wegschmeißen"
            string line = sr.ReadLine();
            Console.WriteLine(line);
            
            // 2 mal identischer Call aber anderes Ergebnis
            string line1 = sr.ReadLine();
            Console.WriteLine(line1);
            */
            string zeile;
            do
            {
                zeile = sr.ReadLine();

                // Ende der Datei
                if (zeile == null)
                {
                    break;
                }
                
                Console.WriteLine(zeile);
            } while (true);

            // hier geht das break hin wenn die Datei "leer" ist
            sr.Close(); // house keeping
            #endregion
            
            #region Nicht ganz so doofes Schreiben
            StreamWriter sw = new StreamWriter(pfad);
            sw.WriteLine("Hallo Welt wie gehts heute so");
            Console.WriteLine("Zeile wurde geschrieben...");
            
            // USB Stick: auswerfen bevor man den Stick vom PC zieht
            // sw.WriteLine() merkt eine Zeile nur zum schreiben vor
            // .Flush() schreibt die Zeile wirklich in die Datei
            sw.Flush();
            
            // Close wie beim SR -> Datei darf nicht im RAM offen bleiben -> Performance
            sw.Close();
            #endregion
        }
    }
}