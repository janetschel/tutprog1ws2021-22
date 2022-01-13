using System;
using System.IO;

namespace TutJan10
{
    public struct Schiff
    {
        public string uhrzeit;
        public string ziel;
        public string preis;

        // Bei Objekterstellung aufgerufen
        public Schiff(string uhrzeit, string ziel, string preis)
        {
            this.uhrzeit = uhrzeit;
            this.ziel = ziel;
            this.preis = preis;
        }
    }
    
    public class Aufgabe4
    {
        public static void Main(string[] args)
        {
            NaechsteFaehren("Calais", 10 ,00);
        }

        public static void NaechsteFaehren(string ort, int std, int min)
        {
            StreamReader sr = new StreamReader(@"/Volumes/Externe Daten/Tutorium/ConsoleApp1/TutJan10/TutJan10/Fahrplan.txt");
            int minutenAbfahrt = std * 60 + min;
            int zaehler = 0;

            // Schiff[] schiffe = new Schiff[3];
            
            while (!sr.EndOfStream)
            {
                string zeile = sr.ReadLine();
                
                // 12:25|Calais nach Dover|€80,00
                string[] strings = zeile.Split("|");
                
                // strings[0] = 12:25
                // strings[1] = Calais nach Dover
                // strings[2] = €80,00

                // Falls Objekt aus Zeile:
                // Schiff s = new Schiff(strings[0], strings[1], strings[2]);
                // schiffe[x] = s;
                
                // 12:25
                string[] uhrzeit = strings[0].Split(":");
                // uhrzeit[0] = 12
                // uhrzeit[1] = 25

                int minuten = Convert.ToInt32(uhrzeit[0]) * 60 + Convert.ToInt32(uhrzeit[1]);
                
                if (strings[1].StartsWith(ort) && minuten >= minutenAbfahrt && zaehler < 3)
                {                                              // oder auch: \t
                    Console.WriteLine($"Fähre von {strings[1]}: {strings[0]}    {strings[2]}");
                    zaehler++; // zaehler = zahler + 1;
                }
            }

            if (zaehler == 0)
            {
                Console.WriteLine("Keine Fähre mehr!");
            }
            
            // NICHT VERGESSEN AUF PAPIER!
            sr.Close();
        }
    }
}