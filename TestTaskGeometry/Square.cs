// Клас для квадрата
public class Square : Shape
{
    private double sideLength;

    public double SideLength
    {
        get { return sideLength; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Довжина сторони квадрата не може бути від'ємною.");
            }

            if (value == 0)
            {
                throw new ArgumentException("Довжина сторони квадрата не може дорівнювати нулю.");
            }
            sideLength = value;
        }
    }

    public Square(double sideLength, string color)
    {
        SideLength = sideLength;
        Color = color;
    }

    public override void Draw()
    {
        Console.WriteLine($"Фігура: квадрат, площа: {GetArea():F4} кв. од., довжина сторони: {SideLength:F4} од., колір: {Color}.");
    }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }
}
