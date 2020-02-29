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

            int testi = 21,
                testi2 = 22,
                testi3 = 23;
            int[] list = { 1, 2, 3, 4, 5 };

            

            Console.WriteLine(kreis.Add(zahl1: testi, zahl2: testi));

            Console.ReadKey();
        }
    }
}
