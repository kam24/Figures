namespace Figures
{
    public class Triangle : Figure
    {
        public double[] SidesLenght { get; private set; }
        private double[] _legs = new double[2];

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Argument(s) cannot be less than or equal to zero");

            if (a + b <= c || a + c <= b || b + c < a)
                throw new ArgumentException("Sum of two arguments less than third argument");

            SidesLenght = new double[] { a, b, c };
        }

        public override double GetArea()
        {
            if (IsRectangular(out _legs))
            {
                return 0.5f * _legs[0] * _legs[1];
            }
            else
            {
                double halfPerimeter = GetPerimeter() / 2;
                double area = halfPerimeter;

                foreach (double sideLenght in SidesLenght)
                    area *= halfPerimeter - sideLenght;
                area = Math.Sqrt(area);
                return area;
            }
        }

        public double GetPerimeter()
        {
            double perimeter = 0;
            foreach (double sideLenght in SidesLenght)
                perimeter += sideLenght;
            return perimeter;
        }

        private bool IsRectangular(out double[] legs)
        {
            int maxSideIndex = 0;
            int firstLegIndex = 1;
            int secondLegIndex = 2;

            for (int i = 0; i < SidesLenght.Length; i++)
                if (SidesLenght[maxSideIndex] < SidesLenght[i])
                    (SidesLenght[i], SidesLenght[maxSideIndex]) = (SidesLenght[maxSideIndex], SidesLenght[i]);

            double legsQuadSum = Math.Pow(SidesLenght[firstLegIndex], 2) + Math.Pow(SidesLenght[secondLegIndex], 2);

            if (Math.Pow(SidesLenght[maxSideIndex], 2) == legsQuadSum)
            {
                legs = new double[2];
                legs[0] = SidesLenght[firstLegIndex];
                legs[1] = SidesLenght[secondLegIndex];
                return true;
            }
            else
            {
                legs = new double[] { 0, 0 };
                return false;
            }
        }
    }
}
