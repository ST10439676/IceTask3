namespace IceTask3;

public class Rectangle : Shape, ICalculateArea {
    public double Width { get; set; }
    public double Height { get; set; }
    
    public Rectangle(double width, double height) : base("Rectangle") {
        Width = width;
        Height = height;
    }

    public double CalculateArea() {
        return Width * Height;
    }

    public override void Display() {
        base.Display();
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Area: {CalculateArea()}");
    }
}