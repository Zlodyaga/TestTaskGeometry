// Клас для трапеції
class Trapezoid : Shape
{
    public double Base1 { get; set; }
    public double Base2 { get; set; }
    public double Height { get; set; }

    public Trapezoid(double base1, double base2, double height, string color)
    {
        Base1 = base1;
        Base2 = base2;
        Height = height;
        Color = color;
    }

    public override void Draw()
    {
        Console.WriteLine($"Фігура: трапеція, площа: {GetArea():F4} кв. од., колір: {Color}."); // Обмеження до 4 знаків після коми у типах double
    }

    public override double GetArea()
    {
        return 0.5 * (Base1 + Base2) * Height;
    }
}
