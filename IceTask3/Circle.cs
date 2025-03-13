namespace IceTask3;

public class Circle : Shape, ICalculateArea {
    public double Radius { get; set; }
    public Circle(double radius) : base("Circle") {
        Radius = radius;
    }

    public double CalculateArea() {
        return 2*Math.PI*Radius;
    }

    public override void Display() {
        base.Display();
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {CalculateArea()}");
    }
}