using System;

public class TestMain
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(37, 43, 2.5);
       
        Console.WriteLine("该圆的圆心的坐标是:{0},{1}", circle.X, circle.Y);
        circle.X = 20;
        circle.Y = 20;

        Console.WriteLine("该圆的新圆心坐标是:{0},{1}", circle.X, circle.Y);
        Console.ReadLine();
    }
}
