using System;
using System.Windows.Media;

namespace FormDemo
{

    class KreisControl
    {
        KreisControl() // Konstruktor
        {
            // Kreis 1 erzeugen und mit Leben füllen
            Kreis k1 = new Kreis();
            k1.setMittelpunkt(20, 30);
            k1.setRadius(20);
            k1.setFarbe(Brushes.White);

            // Kreis 2 erzeugen 
            Kreis k2 = new Kreis();
            k2.setMittelpunkt(100, 200);
            k2.setRadius(40);

            // Quadrat 1 erzeugen 
            Quadrat q1 = new Quadrat();
            q1.setMittelpunkt(12, 14);
            q1.setSeitenlaenge(60);
            q1.setFarbe(Brushes.Black);

            // Ausgabe
            Console.WriteLine("k1 Fläche: " + k1.getFlaeche() + " Farbe: " + k1.getFarbe());
            Console.WriteLine("k2 Fläche: " + k2.getFlaeche() + " Farbe: " + k2.getFarbe());
            Console.WriteLine("q1 Fläche: " + q1.getFlaeche() + " Farbe: " + q1.getFarbe());
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new KreisControl();
        }
    }

}
