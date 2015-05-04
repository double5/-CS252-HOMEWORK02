/*****************************************************************************
 * 程式功能
 * 輸入x
 * 列印出邊長為x的空心正方形
 Ex: 輸入 5
 Sol: 
    *****
    *   *
    *   *
    *   *
    *****
*****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            PlotRetangleHole();
        }
        public static void PlotRetangleHole()
        {
            int InputX;
            Console.Write("請輸入整數x，產生x的中空正方形: ");
            InputX =int.Parse( Console.ReadLine());
            for(int i =0; i<=InputX ; i++)
            {
                if(i == 0 || i ==InputX)
                { 
                    for(int j=0; j<=InputX ;j++)
                    {
                        Console.Write("*");                 
                    }
                }
                else
                {
                    Console.Write("*");
                    for( int j =0; j<=(InputX-2) ;j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
