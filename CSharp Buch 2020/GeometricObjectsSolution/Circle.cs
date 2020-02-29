using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricObjectsSolution
{
    public class Circle
    {
		private int _Radius;

		public int Radius
		{
            get
            {
                return _Radius;
            }
            set
            {
                if (value >= 0)
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

        private int _Value;

        public int Value
        {
            get { return _Value; }
            set { _Value = value; }
        }    
    }
}
