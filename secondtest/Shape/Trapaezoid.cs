using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trapaezoid:Quadrilateral//梯形类
{
    private double a;

    public double A
    {
        get { return this.a; }
        set { this.a = value; }
    }
    private double b;

    public double B
    {
        get { return this.b; }
        set { this.b = value; }
    }

    private double c;

    public double C
    {
        get { return this.c; }
        set { this.c = value; }
    }

    private double d;

    public double D
    {
        get { return this.d; }
        set { this.d = value; }
    }

    public Trapaezoid():base(0,0,0,0) 
    {
        base.X = base.Y =base.Z=base.K = 0;  //base表示其基类
    //    this.a = 1.0; this.b = 1.0; this.c = 1.0; this.d = 1.0;
    }

    //新增构造函数
    public Trapaezoid(double x, double y, double z,double k):base(x,y,z,k)
    {
        base.X = x;
        base.Y = y;
        base.Z = z;
        base.K = k;
    }


    //返回梯形的周长
    public double CircumFerence()
    {
        double a;
        a = this.X + this.Y + this.Z + this.K;
        return a;
    }


    public override string ToString()
    {
        return "[" + this.X + " , " + this.Y + ", " + this.Z + ", " + this.K + "]";
    }

    ~Trapaezoid() { }

}

