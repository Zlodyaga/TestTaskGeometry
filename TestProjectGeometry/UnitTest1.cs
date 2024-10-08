namespace TestProjectGeometry
{
    [TestFixture]
    public class Tests1
    {
        [Test]
        public void SquareAreaTest()
        {
            var square = new Square(5, "синій");
            double area = square.GetArea();
            Assert.AreEqual(25, area, "Площа квадрата повинна бути 25.");
        }

        [Test]
        public void SquareColorTest()
        {
            var square = new Square(5, "синій");
            string color = square.Color;
            Assert.AreEqual("синій", color, "Колір квадрата повинен бути синім.");
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(5, 5, 7.1, "жовтий");
            double area = triangle.GetArea();
            Assert.AreEqual(12.5, area, 0.01, "Площа трикутника повинна бути 12.5.");
        }

        [Test]
        public void TriangleHypotenuseTest()
        {
            var triangle = new Triangle(5, 5, 7.1, "жовтий");
            double hypotenuse = triangle.Hypotenuse;
            Assert.AreEqual(7.1, hypotenuse, 0.01, "Гіпотенуза повинна бути 7.1.");
        }

        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(5, "червоний");
            double area = circle.GetArea();
            Assert.AreEqual(Math.PI * 25, area, 0.01, "Площа кола повинна бути π * 25.");
        }

        [Test]
        public void CircleRadiusTest()
        {
            var circle = new Circle(5, "червоний");
            double radius = circle.Radius;
            Assert.AreEqual(5, radius, "Радіус кола повинен бути 5.");
        }

        [Test]
        public void TrapezoidAreaTest()
        {
            var trapezoid = new Trapezoid(5, 7, 4, "зелений");
            double area = trapezoid.GetArea();
            Assert.AreEqual(24, area, "Площа трапеції повинна бути 24.");
        }

        [Test]
        public void TrapezoidColorTest()
        {
            var trapezoid = new Trapezoid(5, 7, 4, "зелений");
            string color = trapezoid.Color;
            Assert.AreEqual("зелений", color, "Колір трапеції повинен бути зеленим.");
        }

        // Негативні тести

        [Test]
        public void SquareNegativeSideLengthTest()
        {
            Assert.Throws<ArgumentException>(() => new Square(-5, "синій"), "Сторона квадрата не може бути від'ємною.");
        }

        [Test]
        public void TriangleNegativeBaseLengthTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5, 5, 7.1, "жовтий"), "Основа трикутника не може бути від'ємною.");
        }

        [Test]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-5, "червоний"), "Радіус кола не може бути від'ємним.");
        }

        [Test]
        public void TrapezoidInvalidHeightTest()
        {
            Assert.Throws<ArgumentException>(() => new Trapezoid(5, 7, -4, "зелений"), "Висота трапеції не може бути від'ємною.");
        }

        [Test]
        public void SquareZeroSideLengthTest()
        {
            Assert.Throws<ArgumentException>(() => new Square(0, "синій"), "Сторона квадрата не може дорівнювати нулю.");
        }

        [Test]
        public void CircleZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0, "червоний"), "Радіус кола не може дорівнювати нулю.");
        }

        [Test]
        public void TrapezoidZeroHeightTest()
        {
            Assert.Throws<ArgumentException>(() => new Trapezoid(5, 7, 0, "зелений"), "Висота трапеції не може дорівнювати нулю.");
        }

        [Test]
        public void TriangleZeroBaseLengthTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 5, 7.1, "жовтий"), "Основа трикутника не може дорівнювати нулю.");
        }
    }
}
