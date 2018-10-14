using System;

namespace lab3
{
    class EllipticalCylinder : Shape
    {
        public EllipticalCylinder (double a, double b, double height) : base(a, b, height) {}
        public override void getArea() {
            double area = (Math.PI * (a + b) * height) + (2 * Math.PI * a * b);
            Console.WriteLine(area);
        }
// Total Surface Area = (π × (A + B) × h) + (2 × π × A × B)
        public override void getVolume(){
            double volume = Math.PI * a * b * height;
            Console.WriteLine(volume);
        }
    }
}
