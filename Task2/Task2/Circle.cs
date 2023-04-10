using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Circle : Shape, IComparable<Shape>
    {
        private double radius;
        public double Radius { get => radius; set => radius = value; }
        public Circle(string name, double radius) : base(name)
        {
            if(radius < 0)
                throw new ArgumentOutOfRangeException(nameof(radius));

            if(name == null)
                throw new ArgumentNullException(nameof(name));

            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Name - {Name} \n" +
                              $"Area = {Area()} \n" +
                              $"Perimeter = {Perimeter()}");
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"Area = {Area()}");
        }

        public override int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}
