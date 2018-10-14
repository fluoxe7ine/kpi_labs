using System;

namespace lab3
{
    class Cylinder : Shape
    {
        public Cylinder (double radius, double height) : base(radius, height) {}
        public override void getArea() {
            double area = 2*Math.PI*radius*height+2*Math.PI*Math.Pow(radius, 2);
            Console.WriteLine(area);
        }

        public override void getVolume(){
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine(volume);
        }
    }
}
