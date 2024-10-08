using System.Text;

// Основна програма
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8; //Команда для налагодження української мови в консолі

        Random random = new Random();
        List<Shape> shapes = new List<Shape>();

        // Генерація випадкового набору фігур
        for (int i = 0; i < random.Next(5, 10); i++) // випадкова кількість фігур
        {
            int figureType = random.Next(1, 5);
            switch (figureType)
            {
                case 1:
                    shapes.Add(new Square(random.Next(1, 10), GetRandomColor()));
                    break;
                case 2:
                    shapes.Add(new Triangle(random.Next(1, 10), random.Next(1, 10), random.Next(5, 10), GetRandomColor()));
                    break;
                case 3:
                    shapes.Add(new Circle(random.Next(1, 10), GetRandomColor()));
                    break;
                case 4:
                    shapes.Add(new Trapezoid(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10), GetRandomColor()));
                    break;
            }
        }

        // Виведення інформації про фігури
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }

    static string GetRandomColor()
    {
        string[] colors = { "червоний", "синій", "зелений", "жовтий", "білий" };
        Random random = new Random();
        return colors[random.Next(colors.Length)];
    }
}
