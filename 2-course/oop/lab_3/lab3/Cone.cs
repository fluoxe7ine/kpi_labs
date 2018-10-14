using System;

namespace lab3
{
    class Cone : Shape
    {
        public Cone (double radius, double height) : base(radius, height) {}
        public override void getArea() {
            double area = Math.PI * radius * (radius + Math.Sqrt(Math.Pow(height, 2) + Math.Pow(radius, 2)));
            Console.WriteLine(area);
        }

        public override void getVolume(){
            double volume = Math.PI * Math.Pow(radius, 2) * height / 3;
            Console.WriteLine(volume);
        }
    }
}
