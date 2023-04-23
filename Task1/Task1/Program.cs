using System;
using Task1;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double randomDouble = 10 * rand.NextDouble();
            List<Triangle> triangles = FillList(3);
            foreach (Triangle triangle in triangles)
                triangle.Print();
        }

        public static List<Triangle> FillList(int countTriangles)
        {
            Random rand = new Random();
            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < countTriangles; i++)
            {
                triangles.Add
                    (new Triangle
                        (
                        new Point(Math.Round(10 * rand.NextDouble(), 2), Math.Round(10 * rand.NextDouble(), 2)), 
                        new Point(Math.Round(10 * rand.NextDouble(), 2), Math.Round(10 * rand.NextDouble(), 2)), 
                        new Point(Math.Round(10 * rand.NextDouble(), 2), Math.Round(10 * rand.NextDouble(), 2))
                        )
                    );
            }
            return triangles;
        }
    }
}
