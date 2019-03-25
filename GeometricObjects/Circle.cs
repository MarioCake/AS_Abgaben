using System;

namespace GeometricObjects
{
  public class Circle : GeometricObject, IDisposable
  {
    // ---------- Felder -------------
    private double _Radius;
    private bool disposed;

    // --------- Statisches Feld -----------
    private static int _CountCircles;

    // --------- Konstruktoren ---------------
    public Circle() {
        _CountCircles++;
    }

    public Circle(double radius) : this()
    {
      Radius = radius;
    }

    public Circle(double radius, int xPos, int yPos) :this(radius)
    {
      Point = new Vector(xPos, yPos);
    }

    // Objektfreigabe
    public void Dispose()
    {
        if (!disposed)
        {
            _CountCircles--;
            GC.SuppressFinalize(this);
            disposed = true;
        }
    }

    ~Circle()
    {
        Dispose();
    }

    // -------- Eigenschaftsmethoden ----------
    public virtual double Radius
    {
      get { return _Radius; }
      set {
        if (value >= 0)
          _Radius = value;
        else
          Console.WriteLine("Unzulässiger negativer Radius.");
      }
    }

    // ---------- Klasseneigenschaft -----------------
    public static int CountCircles
    {
        get { return _CountCircles; }
    }

    // ---------- Instanzmethoden ----------
    public override double GetArea()
    {
      return Math.PI * Math.Pow(Radius, 2);
    }

    public override double GetCircumference()
    {
      return 2 * Math.PI * Radius;
    }

    public virtual void Move(int dx, int dy, int dRadius)
    {
        Point.Add(dx, dy);
        Radius += dRadius;
    }

    public override string ToString()
    {
        return "Circle, R=" + Radius + ",Fläche=" + GetArea();
    }

    // -------- Klassenmethoden ------------
    public static double GetArea(int radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }   

    public static double GetCircumference(double radius)
    {
        return 2 * Math.PI * radius;
    }
  }
}
