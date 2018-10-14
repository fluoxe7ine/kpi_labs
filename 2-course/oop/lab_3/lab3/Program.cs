using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape t1 = new Cylinder(3, 4.5);
            Console.WriteLine("Cylinder:");
            t1.getArea();
            t1.getVolume();
            Console.WriteLine();

            Shape t2 = new Cone(3, 4.5);
            Console.WriteLine("Cone:");
            t2.getArea();
            t2.getVolume();
            Console.WriteLine();

            Shape t3 = new EllipticalCylinder(3, 3, 4.5);
            Console.WriteLine("Elliptical Cylinder:");
            t3.getArea();
            t3.getVolume();
        }
    }
}
