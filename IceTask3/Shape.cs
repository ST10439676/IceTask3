namespace IceTask3;

public abstract class Shape {
    public string Name { get; set; }

    protected Shape(string name) {
        Name = name;
    }

    public virtual void Display() {
        Console.WriteLine($"Name: {Name}");
    }
}