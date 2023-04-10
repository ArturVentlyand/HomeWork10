using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name { get => name; set => name = value; }
        public Shape(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            Name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public virtual void Display()
        {
            Console.WriteLine($"Name - {Name} \n" +
                              $"Area = {Area()} \n" +
                              $"Perimeter = {Perimeter()}");
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area = {Area()}");
        }

        public virtual int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}