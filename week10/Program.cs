using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Enter the number of times you want to enter the names:");
//        int count;
//        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
//        {
//            Console.WriteLine("Please enter a valid positive integer.");
//        }

//        string[] names = new string[count];

//        for (int i = 0; i < count; i++)
//        {
//            Console.Write($"Enter name {i + 1}: ");
//            names[i] = Console.ReadLine();
//        }

//        Console.WriteLine("\nNames entered:");
//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}




class Circle
{
    private double radius;
    private double xCenter;
    private double yCenter;

    public Circle(double r, double x, double y)
    {
        radius = r;
        xCenter = x;
        yCenter = y;
    }

    public double GetSurface()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public bool IsPointInside(double x, double y)
    {
        double distance = Math.Sqrt(Math.Pow(x - xCenter, 2) + Math.Pow(y - yCenter, 2));
        return distance <= radius;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Circle with radius {radius}, center at ({xCenter},{yCenter}), Surface: {GetSurface()}, Perimeter: {GetPerimeter()}");
    }
}

class Program
{
    static void Main()
    {
        int numberOfCircles = GetNumberOfCirclesFromUser();
        Circle[] circles = CreateCircles(numberOfCircles);

        for (int i = 0; i < numberOfCircles; i++)
        {
            circles[i].PrintInfo();
            CheckPointInsideCircle(circles[i]);
        }
    }

    static int GetNumberOfCirclesFromUser()
    {
        int numberOfCircles;
        do
        {
            Console.Write("Enter the number of circles you want to create: ");
        } while (!int.TryParse(Console.ReadLine(), out numberOfCircles) || numberOfCircles <= 0);
        return numberOfCircles;
    }

    static Circle[] CreateCircles(int numberOfCircles)
    {
        Circle[] circles = new Circle[numberOfCircles];
        for (int i = 0; i < numberOfCircles; i++)
        {
            Console.WriteLine($"\nCircle {i + 1}:");
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Enter x-coordinate of center: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y-coordinate of center: ");
            double y = double.Parse(Console.ReadLine());
            circles[i] = new Circle(radius, x, y);
        }
        return circles;
    }

    static void CheckPointInsideCircle(Circle circle)
    {
        Console.Write("Enter x-coordinate of the point: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y-coordinate of the point: ");
        double y = double.Parse(Console.ReadLine());
        if (circle.IsPointInside(x, y))
        {
            Console.WriteLine("The point is inside the circle.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle.");
        }
    }
}

