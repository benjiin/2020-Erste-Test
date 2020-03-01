using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjectsSolution
{
    public class Circle
    {
        private int _Radius;

        public Circle() 
        {
            Radius = radius;
        }

        public Circle(int radius, double x, double y)
        {
            XCoordinate = x;
            YCoordinate = y;
            Radius = radius;
        }

        public int Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                if(value >= 0)
                {
                    _Radius = value;
                }
                else
                {
                    Console.WriteLine("Unzulässiger Wert.");
                }
            }
        }
        private double _YCoordinate;

        public double YCoordinate
        {
            get { return _YCoordinate; }
            set { _YCoordinate = value; }
        }

        private double _XCoordinate;

        public double XCoordinate
        {
            get { return _XCoordinate; }
            set { _XCoordinate = value; }
        }

        //Methoden
        public double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
        public double GetCircumference()
        {
            return 2 * Radius * Math.PI;
        }
        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }       
        public void Move(double dx, double dy, int dRadius)
        {
            XCoordinate += dx;
            YCoordinate += dy;
            Radius += dRadius;
        }

        public int Bigger(Circle kreis)
        { 
            if(kreis == null || Radius > kreis.Radius)
            {
                return 1;
            }
            if(Radius < kreis.Radius)
            {
                return -1;
            }
            return 0;
        }

        public long Add(int zahl1, int zahl2, params int[] list)
        {
            long sum = zahl1 + zahl2;
            foreach(int z in list)
            {
                sum += z;
            }
            return sum;
        }
    }

}
