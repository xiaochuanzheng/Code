﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    public class book_ticket
    {
        public static void Main()
        {
            int[] A = new int[10];
            int next;
            Console.WriteLine("欢迎使用南方航空公司订票系统:");
            Console.WriteLine("1预订头等仓(1-5号座位)\n2预订经济仓(6-10号座位)\n-1退出");
            do
            {
                Console.WriteLine("请选择:");
                next = int.Parse(Console.ReadLine());
                switch (next)
                {
                    case 1:
                        Console.WriteLine("请输入座位号:");
                        int next1 = int.Parse(Console.ReadLine());
                        if ((next1 < 1) || (next1 > 5))
                        {
                            Console.WriteLine("您的输入有误,请重新输入(头等仓的座号范围是1-5)");
                            continue;
                        }
                        if (A[next1 - 1] == 1)
                        {
                            Console.WriteLine("抱歉...该座位{0}已被预订!", next1);
                        }
                        else
                        {
                            A[next1 - 1] = 1;
                            Console.WriteLine("ok...预订成功,您的座位是{0}号.", next1);
                        }
                        break;
                    case 2:
                        Console.WriteLine("请输入座位号:");
                        int next2 = int.Parse(Console.ReadLine());
                        if ((next2 < 6) || (next2 > 10))
                        {
                            Console.WriteLine("您的输入有误,请重新输入(经济仓的座号范围是6-10)");
                            continue;
                        }
                        if (A[next2 - 1] == 1)
                        {
                            Console.WriteLine("抱歉...该座位{0}已被预订!", next2);
                        }
                        else
                        {
                            A[next2 - 1] = 1;
                            Console.WriteLine("ok...预订成功,您的座位是{0}号.", next2);
                        }
                        break;
                    case -1:
                        break;
                    default:
                        break;
                }
            } while (next != -1);
        }
    }
}
