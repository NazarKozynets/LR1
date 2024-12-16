namespace LabaSecondTask;

public class TSquare
    {
        protected float side; 

        public TSquare()
        {
            side = 0; 
        }

        public TSquare(float side)
        {
            this.side = side;
        }

        public TSquare(TSquare other)
        {
            this.side = other.side;
        }

        public float CalculateArea()
        {
            return side * side;
        }

        public float CalculatePerimeter()
        {
            return 4 * side;
        }

        public override string ToString()
        {
            return $"Square: Side = {side}, Area = {CalculateArea()}, Perimeter = {CalculatePerimeter()}";
        }

        public void Input()
        {
            Console.Write("Enter the length of the side: ");
            while (!float.TryParse(Console.ReadLine(), out side))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public void Output()
        {
            Console.WriteLine(side); 
        }

        //public bool Equals(TSquare other)
        //{
          //  return this.side == other.side;
        //}

        public static TSquare operator +(TSquare a, TSquare b)
        {
            return new TSquare(a.side + b.side);
        }

        public static TSquare operator -(TSquare a, TSquare b)
        {
            return new TSquare(Math.Max(a.side - b.side, 0)); 
        }

        public static TSquare operator *(TSquare square, float factor)
        {
            return new TSquare(square.side * factor);
        }
    }
    //base викликає конструктор чи метод батьківського класу в дочерньому
public class TCube : TSquare
{
    public TCube() : base() 
    {
    }

    public TCube(float side) : base(side) 
    {
    }

    public TCube(TCube other) : base(other) 
    {
    }

    public new float CalculateArea()
    {
        return 6 * side * side; 
    }
    
    public float CalculateVolume()
    {
        return (float)Math.Pow(side, 3);
    }

    public override string ToString()
    {
        return $"Cube: Side = {side}, Area = {CalculateArea()}, Perimeter = {CalculatePerimeter()}, Area = {CalculateArea()}";
    }
    
    public static TCube operator +(TCube a, TCube b)
    {
        return new TCube(a.side + b.side);
    }

    public static TCube operator -(TCube a, TCube b)
    {
        return new TCube(Math.Max(a.side - b.side, 0));
    }

    public static TCube operator *(TCube cube, float factor)
    {
        return new TCube(cube.side * factor);
    }
}