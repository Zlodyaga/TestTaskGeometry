// Клас для кола
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, string color)
    {
        Radius = radius;
        Color = color;
    }

    public override void Draw()
    {
        Console.WriteLine($"Фігура: коло, площа: {GetArea():F4} кв. од., радіус: {Radius:F4} од., колір: {Color}."); // Обмеження до 4 знаків після коми у типах double
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
