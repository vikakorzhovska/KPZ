using Task3.Graphics;
using Task3.Shapes;
using Task3;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("=== Графічний редактор ===");

IRenderer vectorRenderer = new VectorRenderer();
Shape vectorCircle = new Circle(vectorRenderer);
Shape vectorSquare = new Square(vectorRenderer);
Shape vectorTriangle = new Triangle(vectorRenderer);

Console.WriteLine("\nРендеримо векторні фігури:");
vectorCircle.Draw();
vectorSquare.Draw();
vectorTriangle.Draw();

IRenderer rasterRenderer = new RasterRenderer();
Shape rasterCircle = new Circle(rasterRenderer);
Shape rasterSquare = new Square(rasterRenderer);
Shape rasterTriangle = new Triangle(rasterRenderer);

Console.WriteLine("\nРендеримо растрові фігури:");
rasterCircle.Draw();
rasterSquare.Draw();
rasterTriangle.Draw();
    