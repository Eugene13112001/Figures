namespace FigureLib
{
    public abstract class Shape
    {
        public abstract double Square();
    }
    public class Circle : Shape
    {
        double radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override double Square() => Math.PI * Math.Pow(radius, 2);
    }
    public class Triangle : Shape
    {
        private readonly double firstSide;
        private readonly double secondSide;
        private readonly double thirdSide;
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!double.IsNormal(firstSide) || firstSide <= 0)
                throw new Exception("Сторона всегда положительное число.");
            if (!double.IsNormal(secondSide) || secondSide <= 0)
                throw new Exception("Сторона всегда положительное число.");
            if (!double.IsNormal(thirdSide) || thirdSide <= 0)
                throw new Exception("Сторона всегда положительное число.");
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        private double? square;
        public override double Square()
        {
            if (square is null)
            {
                double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
                double s = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
                square = s;
            }
            return square.Value;
        }


        private bool? isSquareness;
        public bool IsSquareness
        {
            get
            {
                

                if (isSquareness is null)
                {
                    double a = firstSide, b = secondSide, c = thirdSide;
                    if (c < b)
                    {
                        (c, b) = (b, c);
                    }
                    if (c < a)
                    {
                        (c, a) = (a, c);
                    }
                    isSquareness = c * c == b * b + a * a;
                }
                return isSquareness.Value;
            }
        }
    }
}