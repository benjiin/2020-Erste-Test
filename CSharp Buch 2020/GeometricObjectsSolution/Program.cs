using System;

namespace GeometricObjectsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis = new Circle();
            kreis.Radius = 12;
            kreis.XCoordinate = 12;
            kreis.YCoordinate = 12;
            kreis.Move(11, 11);
            kreis.Move(0, 0, 1);


            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
