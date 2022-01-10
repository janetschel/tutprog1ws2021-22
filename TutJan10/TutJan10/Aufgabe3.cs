using System;

namespace TutJan10
{
    public class Aufgabe3
    {
        
    }

    public struct Bug
    {
        // fortlaufgende ID zw. mehr. Obj.
        private static int ID = 1;
        
        private int id;
        private string bez;
        private Status status;
        
        // Konstruktor = normale Methode ohne Rückgabetyp
        public Bug(string bez, Status status)
        {
            // Leerer String
            if (bez.Length == 0)
            {
                throw new ArgumentException();
            }

            // Setzen der Struct-Felder
            this.bez = bez;
            this.status = status;
            id = ID;
            ID++; // ID = ID + 1;
        }

        public Bug(string bez)
        {
            // Leerer String
            if (bez.Length == 0)
            {
                throw new ArgumentException();
            }

            // Setzen der Struct-Felder
            this.bez = bez;
            status = Status.Neu; // manuell: Status.Neu
            id = ID;
            ID++; // ID = ID + 1;
        }
    }

    public enum Status
    {
        Neu,
        Offen,
        Bearbeitet,
        Geschlossen
    }
}