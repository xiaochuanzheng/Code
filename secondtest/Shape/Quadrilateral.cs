using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Quadrilateral:Shape//四边形类
{
    private double x; //私有变量，如果是protected则

    public double X //公共属性。控制成员x的可访问性，如果成员是大写的X,那么这里应该是_X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    private double y;//获取2长度
    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    private double z;//获取3长度
    public double Z
    {
        get { return this.z; }
        set { this.z = value; }
    }

    private double k;//获取4长度
    public double K
    {
        get { return this.k; }
        set { this.k = value; }
    }



    //修改构造函数，用边长初始化的新实例。
    public Quadrilateral()
    {
        this.x = this.y =this.z=this.k= 0;
    }

    //用指定坐标初始新实例
    public Quadrilateral(double xco, double yco)
    {
        this.x = xco;
        this.y = yco;
    }
    //重写Shape类的虚方法
    public Quadrilateral(double xco, double yco, double zco)
    {
        this.x = xco;
        this.y = yco;
        this.z = zco;
    }
    public Quadrilateral(double xco, double yco, double zco, double kco)
    {
        this.x = xco;
        this.y = yco;
        this.z = zco;
        this.k = kco;
    }

    public override double Perimeter()
    {
        return 0;
    }

    public override string ToString()
    {
        return "[" + this.x + " , " + this.y + ", " + this.z + ", " + this.k + "]";
    }

}

