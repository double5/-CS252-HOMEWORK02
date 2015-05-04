/*****************************************************************************
 * 程式功能
 * 輸入x (奇數)
 * 列印出長寬為x的十字型圖案
 Ex: 輸入 5
 Sol: 
      *
      *
    *****
      *
      *
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawCross();
        }
        public static bool EndFlag = false; //判斷程式是否結束旗標
        public static void DrawCross()
        {
            int InputX;
            Console.Write("請輸入 x 的值奇數: ");
            
            while( EndFlag == false)
            {
                InputX = int.Parse(Console.ReadLine());
                if((InputX % 2) == 1)
                {
                    for(int i =0; i< InputX ; i++)
                    {
                        if (i == (InputX / 2))
                        {
                            for (int j = 0; j < InputX; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }    
                        else
                        {
                            for (int j = 0; j < InputX; j++)
                            {
                                if( j == (InputX/2))
                                {
                                    Console.Write("*");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }
                            }
                            Console.WriteLine("");
                        }
                    }
                    EndFlag = true;
                }
                else
                {
                    Console.Write("請輸入奇數: ");
                }
            }
        }
    }
}
