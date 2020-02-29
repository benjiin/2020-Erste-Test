using System;

namespace GeometricObjectsSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis1 = new Circle();
            Circle kreis2 = kreis1;
            kreis2.Radius = 20;
            kreis2 = null;

            Console.WriteLine(kreis1.Radius);
            Console.ReadKey();
        }
    }
}
