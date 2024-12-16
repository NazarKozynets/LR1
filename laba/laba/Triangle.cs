namespace Laba
{
    public class Triangle
    {
        private float a, b, c;

        public Triangle(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides of a triangle must be positive numbers greater than zero.");
            }
            
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("The sides provided cannot form a valid triangle.");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public float this[int index]
        {
            get
            {
                return index switch
                {
                    0 => a,
                    1 => b,
                    2 => c,
                    _ => throw new IndexOutOfRangeException("Invalid index. Must be 0, 1, or 2.")
                };
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Side length must be greater than zero.");
                }

                float oldA = a, oldB = b, oldC = c;

                switch (index)
                {
                    case 0: a = value; break;
                    case 1: b = value; break;
                    case 2: c = value; break;
                    default:
                        throw new IndexOutOfRangeException("Invalid index. Must be 0, 1, or 2.");
                }

                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    a = oldA;
                    b = oldB;
                    c = oldC;
                    throw new ArgumentException("The sides provided cannot form a valid triangle after modification.");
                }
            }
        }

        public float CalculatePerimeter()
        {
            return a + b + c;
        }

        public float GetArea()
        {
            float p = CalculatePerimeter() / 2;
            return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void WriteAllSides()
        {
            Console.WriteLine($"First side: {a} \nSecond Side: {b} \nThird side: {c}");
        }
    }
}