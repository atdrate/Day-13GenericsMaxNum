using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to generic method");

            Console.WriteLine("1.Maximum intger number.2.Maximum Float Value:3.Maximum String:4.Refactor1:5.rectaor2:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MaxInteger i = new MaxInteger();
                    int result = i.MaxNum();
                    Console.WriteLine("Maximum number between 3 int numbers: " + result);
                       break;
                     case 2:
                         MaxFloat f = new MaxFloat();
                         double floatresult = f.maxfloat();
                         Console.WriteLine("Maximum number between 3 float numbers: " + floatresult);
                         break;
                   case 3:
                         MaxString s = new MaxString();
                         string stringres = s.maxstring("abc", "abcd", "abcde");
                         Console.WriteLine("Maximum string value is:" + stringres);
                         break;
                       case 4:
                         Refactor1 refactor1 = new Refactor1();
                         int result1 = refactor1.Max(20, 20, 30);
                         Console.WriteLine("Maximum int value is:" + result1);

                         Refactor1 refactor2 = new Refactor1();
                         float result2 = refactor2.Max(2.5f, 32.3f, 3.4f);
                         Console.WriteLine("Maximum float value is:" + result2);

                         Refactor1 refactor3 = new Refactor1();
                         string result3 = refactor3.Max("ab", "bc", "abc");
                         Console.WriteLine("Maximum string is:" + result3);
                         break;
                     case 5:
                          Refactor2<int> gr1 = new Refactor2<int>(500, 300, 100);
                          Console.WriteLine("Maximum Integer value is: " + gr1.Max());

                          Refactor2<float> gr2 = new Refactor2<float>(2.8f, 70.00f, 1.89f);
                          Console.WriteLine("Maximum float value is: " + gr2.Max());

                          Refactor2<string> gr3 = new Refactor2<string>("mango", "Apple", "kiwi");
                          Console.WriteLine("Maximum string is: " + gr3.Max());
                          break;
                    



            }
        }
    }
}
