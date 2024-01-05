using System;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        // Вычисление площади круга по радиусу
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("The radius must be a positive number.");

            return Math.PI * Math.Pow(radius, 2);
        }

        // Вычисление площади треугольника по трем сторонам
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (!IsTriangleValid(sideA, sideB, sideC))
                throw new ArgumentException("A triangle with the given sides does not exist.");

            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        // Проверка на то, является ли треугольник прямоугольным
        public static bool IsRightAngledTriangle(double sideA, double sideB, double sideC)
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        // Проверка валидности треугольника по трем сторонам
        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }
    }
}
