using System;

namespace GeometricObjects
{
  public class Rectangle : GeometricObject
  {
    // ---------- Felder -------------
    private double _Length;
    private double _Width;
    private bool disposed;

    // --------- Statisches Feld -----------
    private static int _CountRectangles;

    // --------- Konstruktoren ---------------
    public Rectangle() {
        _CountRectangles++;
    }

    public Rectangle(double length, double width) : this()
    {
        Length = length;
        Width = width;
    }

    public Rectangle(double length, double width, int xPos, int yPos)  : this(length, width)
    {
      Point = new Vector(xPos, yPos);
    }

    // Objektfreigabe
    public void Dispose()
    {
        if (disposed) return;
        
        _CountRectangles--;
        GC.SuppressFinalize(this);
        disposed = true;
    }

    ~Rectangle()
    {
        Dispose();
    }

    // -------- Eigenschaftsmethoden ----------
    public virtual double Length
    {
      get { return _Length; }
      set {
        if (value >= 0)
          _Length = value;
        else
          Console.WriteLine("Unzulässige negative Länge.");
      }
    }

    public virtual double Width
    {
        get { return _Width; }
        set
        {
            if (value >= 0)
                _Width = value;
            else
                Console.WriteLine("Unzulässige negative Breite.");
        }
    }

    // ---------- Klasseneigenschaft -----------------
    public static int CountRectangles
    {
        get { return _CountRectangles; }
    }

    // ---------- Instanzmethoden ----------
    public override double GetArea()
    {
        return Length * Width;
    }

    public override double GetCircumference()
    {
        return 2 * (Length + Width);
    }

    public virtual void Move(int dx, int dy, int dWidth, int dLength)
    {
        Point.Add(dx, dy);
        Width += dWidth;
        Length += dLength;
    }

    public override string ToString()
    {
        return "Rectangle, L=" + Length + ",B=" + Width + ",Fläche=" + GetArea();
    }


    // -------- Klassenmethoden ------------
    public static double GetArea(int length, int width)
    {
        return length * width;
    }   

    public static double GetCircumfence(int length, int width)
    {
        return 2 * (length + width);
    }
  }
}
