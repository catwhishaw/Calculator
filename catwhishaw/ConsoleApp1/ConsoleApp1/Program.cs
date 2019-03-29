using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace calculator
{
    public class Calculator
    {
        public int a, b, c, d, temp, sum;
        char[] symbol = { '+', '-', '*', '/' };                  //将运算符输入数组
        public Calculator(int temp) { }
        public void Print()
        {
            Random random = new Random();
            Console.WriteLine("输入四则运算题目个数：");
            temp = int.Parse(Console.ReadLine());
            for (int i = 0; i < temp; i++)
            {
                int t = random.Next(1, 9);                     //运算的所有9种组合
                a = random.Next(1, 100);                       //利用随机函数给abcd赋值，范围是1-100
                b = random.Next(1, 100);
                c = random.Next(1, 100);
                d = random.Next(1, 100);
                switch (t)                                     //随机取运算情况
                {
                    case 1:
                        sum = a + b + c;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "+" + b + "+" + c + "=" + sum);
                        break;
                    case 2:
                        c = random.Next(1, a + b);
                        for (; a + b - c < 0;)
                            c = random.Next(1, a + b);
                        sum = a + b - c;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "+" + b + "-" + c + "=" + sum);
                        break;
                    case 3:
                        sum = a + b * c;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "+" + b + "*" + c + "=" + sum);
                        break;
                    case 4:
                        for (; b % c != 0; c = random.Next(1, b))
                            c = random.Next(2, b);
                        sum = a + b / c;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "+" + b + "/" + c + "=" + sum);
                        break;
                    case 5:
                        for (; b % c != 0;)
                            c = random.Next(2, b);
                        sum = a * d + b / c;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "*" + d + "+" + b + "/" + c + "=" + sum);
                        break;
                    case 6:
                        for (; b % c != 0; c = random.Next(1, b))
                            d = random.Next(2, a);
                        sum = a + b / c - d;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "+" + b + "/" + c + "-" + d + "=" + sum);
                        break;
                    case 7:
                        for (; b % c != 0;)
                            c = random.Next(1, b);
                        sum = a + b / c * d;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "+" + b + "/" + c + "*" + d + "=" + sum);
                        break;
                    case 8:
                        sum = a * b + c * d;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "*" + b + "+" + c + "*" + d + "=" + sum);
                        break;
                    case 9:
                        for (; c % d != 0;)
                            d = random.Next(1, c);
                        sum = a * b + c / d;
                        Console.WriteLine("运算为：");
                        Console.WriteLine(a + "*" + b + "+" + c + "/" + d + "=" + sum);
                        break;

                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator x = new Calculator(1);
            x.Print();
            Console.Read();
        }
    }
}