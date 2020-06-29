using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;

namespace Beleg2020
{
    class EingangsLager
    {

        static private bool firstLine = true;
        public static bool Initialisieren(String path)
        {
            List<Tuple<Verarbeitungsschritt, int>> ListeTeileMitRezept;
            path = @"C:\Users\Ericd\Uni\Semester 2\Informatik 2\Beleg\Teil 3\erdr420b\Beleg2020\Teile.csv";


            Console.WriteLine("Einlesen gestartet!");
            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                if (firstLine) { firstLine = false; continue; } // einfach nur die Kopfzeile überspringen

                var strings = line.Split(';');
                var name = strings[0];
                ListeTeileMitRezept = new List<Tuple<Verarbeitungsschritt, int>>();
                for (int i = 1; i < strings.Length; i++)
                {

                    var s = strings[i].Split(':');
                    ListeTeileMitRezept.Add(
                        new Tuple<Verarbeitungsschritt, int>(
                            (Verarbeitungsschritt)Enum.Parse(typeof(Verarbeitungsschritt), s[0]),
                            Int32.Parse(s.Length > 1 ? s[1] : "0")
                            )
                        );
                }

                /**
                 * Hier werden die eigentlichen Objekte erzeugt. 
                 **/
            }
            return true;
        }



        public void BerechneStatus()
        {
            string Status;
            bool TeilVorhanden = true;



            if (TeilVorhanden == true)
            {
                Status = "ABHOLBEREIT";
            }
            else
            {
                Status = "EMPFANGSBEREIT";
            }
        }
    }
}


