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

![](./images/1.jpg)
https://github.com/xiaochuanzheng/Code/tree/master/images/1.jpg

![](./images/2.jpg)
https://github.com/xiaochuanzheng/Code/tree/master/images/2.jpg

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

![](./images/3.jpg)
https://github.com/xiaochuanzheng/Code/tree/master/images/3.jpg

![](./images/4.jpg)
https://github.com/xiaochuanzheng/Code/tree/master/images4.jpg

