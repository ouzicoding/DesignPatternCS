using System;

namespace DesignPatternCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数字A:");
            //
            //TODO ABCD命名不规范
            string A = Console.ReadLine();
            Console.Write("请选择运算符号（+ - * /）：");
            string B = Console.ReadLine();
            Console.Write("请输入数字B:");
            string C = Console.ReadLine();
            string D = "";
            //TODO if浪费资源
            if (B == "+")
                //TODO 方法重复 代码冗余
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            if (B == "-")
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            if (B == "*")
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            if (B == "/")
                //TODO 数据未校验 （除数0）
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));

            Console.WriteLine("结果是：" + D);
        }
    }
}

