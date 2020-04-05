using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExample3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            Double R, S;
            Console.WriteLine("请输入圆的半径:");
            R = double.Parse(Console.ReadLine());
            S = PI * R * R;
            Console.WriteLine("圆的面积为:{0}", S);
            Console.ReadLine();
        }
    }
}
