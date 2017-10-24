using System;

public class TestMain
{
    /* public static void Main(string[] args)
     {
         Circle circle = new Circle(37, 43, 2.5);

         Console.WriteLine("该圆的圆心的坐标是:{0},{1}", circle.X, circle.Y);
         circle.X = 20;
         circle.Y = 20;

         Console.WriteLine("该圆的新圆心坐标是:{0},{1}", circle.X, circle.Y);
         Console.ReadLine();
     }
     */
    public static void Main(string[] args)
    {
        Trapaezoid trapaezoid = new Trapaezoid(30, 60, 40, 40 );

        Console.WriteLine("该梯形的边长是:{0},{1}，{2}，{3}", trapaezoid.X, trapaezoid.Y, trapaezoid.X , trapaezoid.K);
        trapaezoid.X = 20;
        trapaezoid.Y = 40;
        trapaezoid.Z = 30;
        trapaezoid.K = 30;
        Console.WriteLine("该梯形的新边长是:{0},{1}，{2}，{3}", trapaezoid.X, trapaezoid.Y, trapaezoid.X, trapaezoid.K);
        Console.WriteLine("该梯形的周长是:{0}", trapaezoid.X+trapaezoid.Y+trapaezoid.X+trapaezoid.K);
        Console.ReadLine();
    }

}
