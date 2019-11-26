using System;

namespace FormDemo
{

    class Quadrat : Form // hier ist die Vererbung: Das Quadrat ist eine Form
    {
        private double seitenlaenge;
        private double x, y;

        public Quadrat()
        {
            x = 0;
            y = 0;
        }

        public void setMittelpunkt(
            double l_x, double l_y)
        {
            x = l_x;
            y = l_y;
        }

        public void setSeitenlaenge(double s)
        {
            seitenlaenge = s;
        }

        public double getFlaeche()
        {
            return Math.Pow(seitenlaenge, 2);
        }

    }
}
