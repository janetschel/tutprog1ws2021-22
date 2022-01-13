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

        public bool Gefixt()
        {
            if (status == Status.Bearbeitet || status == Status.Geschlossen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IstDuplikat(Bug b)
        {
            // <meine bez> == <bez vom anderen>
            if (this.bez == b.bez)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DuplikateAusgabenParams(params Bug[] bugs)
        {
            DuplikateAusgeben(bugs);
        }

        public void DuplikateAusgeben(Bug[] bugs)
        {
            
            for (int i = 0; i < bugs.Length; i++)
            {
                for (int j = i + 1; j < bugs.Length; j++)
                {
                    if (bugs[i].IstDuplikat(bugs[j]))
                    {
                        Console.WriteLine($"{bugs[i].id} = {bugs[j].id}");
                    }
                }
            }
            
            /*
             * [1, 2, 3, 4, 1, 6, 9]
        i    *  ^                 
        j    *     ^                     
             * 
             */
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