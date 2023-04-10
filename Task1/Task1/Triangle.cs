using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;
        public Point Vertex1 { get { return vertex1; } set { vertex1 = value; } }
        public Point Vertex2 { get { return vertex2; } set { vertex2 = value; } }
        public Point Vertex3 { get { return vertex3; } set { vertex3 = value; } }
        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            Point point = new Point(0, 0);
            if (vertex1.Equals(point) && vertex2.Equals(point))
            {
                if (!(vertex1.Equals(vertex3) && vertex2.Equals(vertex3)))
                {
                    throw new ArgumentException();
                }
            }
            if (vertex1.Equals(point) && vertex3.Equals(point))
            {
                if (!(vertex1.Equals(vertex2) && vertex3.Equals(vertex2)))
                {
                    throw new ArgumentException();
                }
            }
            if (vertex3.Equals(point) && vertex2.Equals(point))
            {
                if (!(vertex3.Equals(vertex1) && vertex2.Equals(vertex1)))
                {
                    throw new ArgumentException();
                }
            }

            this.Vertex1 = vertex1;
            this.Vertex2 = vertex2;
            this.Vertex3 = vertex3;
        }

        public static double Distance(Point point1, Point point2)
        {
            double differenceX = point1.x - point2.x;
            double differenceY = point1.y - point2.y;
            return Math.Sqrt(differenceX * differenceX + differenceY * differenceY);
        }

        public double Perimeter()
        {
            double side1 = Distance(Vertex1, Vertex2);
            double side2 = Distance(Vertex2, Vertex3);
            double side3 = Distance(Vertex3, Vertex1);
            return side1 + side2 + side3;
        }

        public double Square()
        {
            double side1 = Distance(Vertex1, Vertex2);
            double side2 = Distance(Vertex2, Vertex3);
            double side3 = Distance(Vertex3, Vertex1);
            double pHalf = Perimeter() / 2;
            return Math.Sqrt(pHalf * (pHalf - side1) * (pHalf - side2) * (pHalf - side3));
        }

        public void Print()
        {
            Console.WriteLine($"Triangle");
            Console.WriteLine($"Points: {Vertex1}, {Vertex2}, {Vertex3}");
            Console.WriteLine($"Sides: {Distance(Vertex1, Vertex2)}, {Distance(Vertex2, Vertex3)}, {Distance(Vertex3, Vertex1)}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Square: {Square()}");
        }
    }
}
