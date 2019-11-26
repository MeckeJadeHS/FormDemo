using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FormDemo
{
    public class Form // Superklasse, von der Kreis und Quadrat erben
    {
        private Brush farbe;

        public Form() // Konstruktor der Superklasse
        {
            farbe = Brushes.White; // Standard: Alle Formen werden erstmal weiss
        }

        public void setFarbe(Brush b) // man kann für alle Formen die Farbe setzen
        {
            farbe = b; 
        }

        public string getFarbe()
        {
            return farbe.ToString(); // man kann für alle Formen die Farbe abfragen
        }


    }
}
