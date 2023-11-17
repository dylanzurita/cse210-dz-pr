using System;

class Program
{
    static void Main(string[] args)
    {

        List <Shape> shapes = new List<Shape> (); 

        Square square = new Square ("RED", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle ("Blue", 10, 5);
        shapes.Add(rectangle);

        Circle circle = new Circle ("Pink", 4);
        shapes.Add(circle);

        foreach (Shape sha in shapes)
        {
            string color = sha.GetColor();
            double Area = sha.GetArea();

            Console.WriteLine ($"The shap with color {color}, has an area od {Area}");
        }


    }
}
