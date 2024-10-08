// Клас для трикутника
public class Triangle : Shape
{
    private double baseLength;

    public double BaseLength
    {
        get { return baseLength; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Довжина основи трикутника не може бути від'ємною.");
            }

            if (value == 0)
            {
                throw new ArgumentException("Довжина основи трикутника не може дорівнювати нулю.");
            }
            baseLength = value;
        }
    }
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
