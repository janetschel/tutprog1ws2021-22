using System;
using System.IO;

namespace ProgTut2012 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string bestFit = BestFit("Hoersaal", 99);
            Console.WriteLine($"Bester Raum ist: {bestFit}");
        }

        // Aufgabe 1
        public static bool PWCheck(string pw)
        {
            /*
             *  mindestens 12 Zeichen lang sein UND
               mindestens einen Großbuchstaben enthalten UND
               mindestens eine Ziffer enthalten.
             */

            // mindestens 12 Zeichen lang sein UND
            if (pw.Length < 12)
            {
                return false;
            }
            
            bool hasUppercaseLetter = false;
            bool hasDigit = false;
            foreach (char c in pw)
            {
                // mindestens einen Großbuchstaben enthalten
                if (c >= 'A' && c <= 'Z')
                {
                    hasUppercaseLetter = true;
                } 
                
                // mindestens eine Ziffer enthalten.
                if (c >= '0' && c <= '9')
                {
                    hasDigit = true;
                }
            }

            return hasUppercaseLetter && hasDigit;
        }
        
        // Aufgabe 2
        public static int[,] ZeileLöschen(int[,] feld, uint znr)
        {
            // wenn kein uint als znr -> znr < 0 || ...
            if (znr >= feld.GetLength(0))
            {
                throw new ArgumentOutOfRangeException();
            }

            // Erstellen eines neuen Feldes mit EXAKTEN Dimensionen wie orig. feld
            int[,] neuesFeld = new int[
                feld.GetLength(0) - 1, // Zeile wird eins weniger, nicht mit 0 aufgefüllt
                feld.GetLength(1)
            ];

            for (int i = 0; i < neuesFeld.GetLength(0); i++)
            {
                for (int j = 0; j < neuesFeld.GetLength(1); j++)
                {
                    if (i != znr) // Bis auf meine Zeilennummer...
                    {
                        // ....Kopieren von Zeile und Spalte in neues Feld
                        neuesFeld[i, j] = feld[i, j];
                    }
                }
            }

            return neuesFeld;
        }
        
        // Aufgabe 4
        public static string BestFit(string raumart, int tn)
        {
            StreamReader reader = new StreamReader("/Volumes/Externe Daten/Tutorium/ConsoleApp1/ProgTut2012/ProgTut2012/raeume.txt");
            
            // Beste Differenz
            int besteDifferenz = 1000;
            string raum = null;

            // Für jede Zeile 
            while (!reader.EndOfStream) // Bis zum Ende der Datei
            {
                string line = reader.ReadLine();

                // HW.303;Hoersaal;110;2 -> ["HW.303", "Hoersaal", ...]
                string[] zeileGesplittet = line.Split(";");

                // Raum qualifiziert sich erstmal (ein möglicher Kandidat)
                if (raumart == zeileGesplittet[1])
                {
                    // Bestmögliche Größe
                    int differenz = Convert.ToInt32(zeileGesplittet[2]) - tn;
                    
                    // Besserer Raum gefunden! Falls differenz < 0 -> Raum zu klein!
                    if (differenz < besteDifferenz && differenz >= 0)
                    {
                        besteDifferenz = differenz; // neuer bester Raum
                        raum = zeileGesplittet[0]; // Speichern vom Raumnamen in raum
                    }
                }
            }
            
            reader.Close();
            
            // Falls kein passender Raum gefunden wird, soll null zurückgeliefert werden.
            return raum; // in raum steht null, falls kein passender Raum gefunden
        }
    }
}