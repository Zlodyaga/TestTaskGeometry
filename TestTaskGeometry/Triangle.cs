// Клас для трикутника
class Triangle : Shape
{
    public double BaseLength { get; set; }
    public double Height { get; set; }
    public double Hypotenuse { get; set; }

    public Triangle(double baseLength, double height, double hypotenuse, string color)
    {
        BaseLength = baseLength;
        Height = height;
        Hypotenuse = hypotenuse;
        Color = color;
    }

    public override void Draw()
    {
        Console.WriteLine($"Фігура: трикутник, площа: {GetArea():F4} кв. од., гіпотенуза: {Hypotenuse} од., колір: {Color}."); // Обмеження до 4 знаків після коми у типах double
    }

    public override double GetArea()
    {
        return 0.5 * BaseLength * Height;
    }
}
