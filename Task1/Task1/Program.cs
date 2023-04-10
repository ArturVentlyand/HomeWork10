using System;
using Task1;

/*
Создайте struct Point:
    - поля x и y, 
    - метод ToString(), который возвращает точку в формате "(x,y)".
   Создайте класс Triangle:
    - поля vertex1, vertex2, vertex3 типа Point
    - конструкторы
    - метод Distance() для вычисления расстояния между точками
    - методы Perimeter(), Square(), Print().
  В Main() создайте список из 3 треугольников и запишите в консоль информацию об этих фигурах.
Добавьте проект Test к вашему решению и напишите модульные тесты для классов Point и Triangle.
Добавьте модульные тесты для одного из ваших предыдущих классов - Person, Car ...
 */

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