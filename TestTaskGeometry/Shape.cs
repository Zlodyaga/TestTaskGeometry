// Базовий клас для фігур
abstract class Shape
{
    public string Color { get; set; }

    // Метод для малювання фігури (виведення на екран)
    public abstract void Draw();

    // Метод для обчислення площі
    public abstract double GetArea();
}
