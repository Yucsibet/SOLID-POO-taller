

using DemoOpenClosePrinciple;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;

Triangle triangle1 = new Triangle();
triangle1.Base = 5;
triangle1.Altura = 2;

Triangle triangle2 = new Triangle();
triangle2.Base = 4;
triangle2.Altura = 3;

Triangle triangle3= new Triangle();
triangle3.Base = 8;
triangle3.Altura = 8;

Rectangle rectangle1 = new Rectangle();
rectangle1.Base = 9;
rectangle1.Altura = 2;

Rectangle rectangle2 = new Rectangle();
rectangle2.Base = 9;
rectangle2.Altura = 7;

Rectangle rectangle3 = new Rectangle();
rectangle3.Base = 8;
rectangle3.Altura = 2;

Trapeze trapeze1 = new Trapeze();
trapeze1.BaseMayor = 10;
trapeze1.BaseMenor = 8;
trapeze1.Altura = 5;

Trapeze trapeze2 = new Trapeze();
trapeze2.BaseMayor = 10;
trapeze2.BaseMenor = 8;
trapeze2.Altura = 5;

Trapeze trapeze3 = new Trapeze();
trapeze3.BaseMayor = 10;
trapeze3.BaseMenor = 8;
trapeze3.Altura = 5;


List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangle1);
shapes.Add(triangle2);
shapes.Add(triangle3);
shapes.Add(rectangle1);
shapes.Add(rectangle2);
shapes.Add(rectangle3 );
shapes.Add(trapeze1);
shapes.Add(trapeze2);
shapes.Add(trapeze3);

var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");