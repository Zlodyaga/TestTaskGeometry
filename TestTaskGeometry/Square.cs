// Клас для квадрата
class Square : Shape
{
    public double SideLength { get; set; }

    public Square(double sideLength, string color)
    {
        SideLength = sideLength;
        Color = color;
    }

    public override void Draw()
    {
        Console.WriteLine($"Фігура: квадрат, площа: {GetArea():F4} кв. од., довжина сторони: {SideLength:F4} од., колір: {Color}."); // Обмеження до 4 знаків після коми у типах double
    }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }
}
