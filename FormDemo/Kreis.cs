using System;

namespace FormDemo
{

    public class Kreis : Form  // hier ist die Vererbung: Der Kreis ist eine Form
    {
        private double radius;
        private double x, y;

        public Kreis()
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

        public void setRadius(double r)
        {
            radius = r;
        }

        public double getFlaeche()
        {
            return ((Math.Pow(radius, 2)) * Math.PI);
        }

    }
}