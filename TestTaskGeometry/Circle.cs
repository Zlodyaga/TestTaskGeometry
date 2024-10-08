// Клас для кола
public class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Радіус кола не може бути від'ємним.");
            }

            if (value == 0)
            {
                throw new ArgumentException("Радіус кола не може дорівнювати нулю.");
            }
            radius = value;
        }
    }

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
