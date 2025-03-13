namespace IceTask3;

class Program {
    static void Main(string[] args) {
        var menu = $"""
                    (1) Rectangle 
                    (2) Circle
                    Choose Shape: 
                    """;

        Console.Write(menu);
        var option = Console.ReadLine()!;
        Shape? shape = null; 
        switch (option) {
            case "1":
                Console.Write("Width: ");
                var width = double.Parse(Console.ReadLine()!);
                Console.Write("Height: ");
                var height = double.Parse(Console.ReadLine()!);

                shape = new Rectangle(width, height);                
                
                break;
            case "2":
                Console.Write("Radius: ");
                var radius = int.Parse(Console.ReadLine()!);

                shape = new Circle(radius);
                break;
            default:
                // Nothing need to be done here shape is null;
                break;
            
        }

        
        Console.WriteLine($"Displaying Shape {shape?.Name ?? "Unknown Shape"}");
        // This won't display anything when shape is null
        // Therefore if (shape is not null) is redundant.
        // Error Checking is performed on the previous line,
        // using the null coalescing operator (??).
        shape?.Display();

    }
}