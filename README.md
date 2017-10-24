# Code
daily code

## HelloWorld程序
```
using System;<br>
namespace Helloworld<br>
{    <br>
class Program    <br>
{     <br>
static void Main(string[] args)<br>
{  <br>
Console.WriteLine("Hello World!");    <br>  
}    <br>
} <br>
}<br>
```
## 窗体： 按钮单击事件改编文本框的内容
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "等于二";
        }
    }
}
```
### 显示结果如下：

![](./images/1.png)
https://github.com/xiaochuanzheng/Code/tree/master/images/1.png

![](./images/2.png)
https://github.com/xiaochuanzheng/Code/tree/master/images/2.png

## 窗体： 按钮单击事件弹出另一个窗体
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
```
### 显示结果如下：

![](./images/3.png)
https://github.com/xiaochuanzheng/Code/tree/master/images/3.png

![](./images/4.png)
https://github.com/xiaochuanzheng/Code/tree/master/images4.png


## 继承：梯形继承四边形，四边形继承shape
```
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

```

### 重写梯形类

```
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
        return (this.X + this.Y + this.Z + this.K);
    }


    public override string ToString()
    {
        return "[" + this.X + " , " + this.Y + ", " + this.Z + ", " + this.K + "]";
    }

    ~Trapaezoid() { }

}

```
## testmain测试
```
using System;

public class TestMain
{

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

```
## 测试结果如下
![](./imgs/梯形继承.png)

