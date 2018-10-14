using System;

namespace lab3
{
    abstract class Shape
    {
        protected double a;
        protected double b;
        protected double height;
        protected double radius;

        public Shape (double radius, double height) {
            this.radius = radius;
            this.height = height;
        }

        public Shape (double a, double b, double height) {
            this.a = a;
            this.b = b;
            this.height = height;
        } 

        public abstract void getArea();
        public abstract void getVolume();
    }
}
