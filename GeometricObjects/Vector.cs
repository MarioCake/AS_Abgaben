namespace GeometricObjects
{
    public struct Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public void Add(Vector other)
        {
            X += other.X;
            Y += other.Y;
        }
        
        public void Add(int x, int y)
        {
            X += x;
            Y += y;
        }

        public static Vector Add(Vector first, Vector other)
        {
            return new Vector {X = first.X + other.X, Y = first.Y + first.Y};
        }
    }
}