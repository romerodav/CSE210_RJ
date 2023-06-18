using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        Square quad;
        Rectangle rect;
        Circle circ;
        string op, color, dimen;
        double dim, dimad;
        List<Shape> shapes = new List<Shape>();

        do
        {
            Console.Write("Choose the shape you wish to work with:\n\n1-Square\n2-Rectangle\n3-Circle\n4-List\n5-Quit\n\nPlease enter your option: ");
            op = Console.ReadLine();
            op = op.Trim();

            if(op == "1" | op == "2" | op == "3" | op == "4")
            {
                if(op == "4") foreach(Shape shape in shapes) Console.WriteLine($"{shape.GetType().Name} color {shape.GetColor()} and area {shape.GetArea()}");
                else
                {
                    Console.Write("Please enter the shape color: ");
                    color = Console.ReadLine();
                    color = color.Trim();

                    if(op == "1")
                    {
                        Console.Write("Please enter the square side: ");
                        dimen = Console.ReadLine();
                        dim = double.Parse(dimen.Trim());
                        quad = new Square(color, dim);
                        Console.WriteLine($"Square color {quad.GetColor()} and area {quad.GetArea()}");
                        shapes.Add(quad);
                    }
                    else
                    {
                        if (op == "2")
                        {
                            Console.Write("Please enter the rectangle width: ");
                            dimen = Console.ReadLine();
                            dim = double.Parse(dimen.Trim());
                            Console.Write("Please enter the rectangle length: ");
                            dimen = Console.ReadLine();
                            dimad = double.Parse(dimen.Trim());
                            rect = new Rectangle(color, dim, dimad);
                            Console.WriteLine($"Square color {rect.GetColor()} and area {rect.GetArea()}");
                            shapes.Add(rect);
                        }
                        else
                        {
                            Console.Write("Please enter the circle radius: ");
                            dimen = Console.ReadLine();
                            dim = double.Parse(dimen.Trim());
                            circ = new Circle(color,dim);
                            Console.WriteLine($"Square color {circ.GetColor()} and area {circ.GetArea()}");
                            shapes.Add(circ);
                        }
                    }
                }
                Console.Write("Please press <Enter> to exit...");
                while (Console.ReadKey().Key != ConsoleKey.Enter);
            }
            Console.Clear();
        }while(op != "5");
        Console.WriteLine("Thanks for using this program! Please come back soon...");
    }
}