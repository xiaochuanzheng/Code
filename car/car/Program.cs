using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace car
{

    //定义Car类
    public class Car
    {
        //定义要访问的字段
        private string color;
        private string name;
        private string productPlace = "吉林";

        //Color属性：包装color字段
        public string Color
        {
            get { return color; }//返回属性值
            set { color = value; }//设置属性值
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductPlace
        {
            get { return productPlace; }//因为此属性只读的，所以没有set(作用给属性赋值)
        }

        public void Run()
        {
            Car car = new Car();//实例化汽车对象
            car.Name = "大众";//给属性Name赋值并返回所赋的值
            car.Color = "黑色";
            Console.WriteLine(car.Name + car.Color + car.ProductPlace);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();
            Console.ReadKey();
        }
    }
}