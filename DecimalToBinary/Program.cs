using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    //Binary representation of a given number   
    class Program
    {
        static void Main(string[] args)
        {
             //  int x = 4;
            int x = 10;
            // int x = 0;
            // int x = 101;
            //

            //DecimalToBinary(x);
            int decNum = x;
            int r;
            Stack<int> stack = new Stack<int>();
            if (x == 0)
                Console.WriteLine("Binary representation of 0 is 0");
            else
                while (x > 0)
                {
                    r = x % 2;
                    stack.Push(r);
                    x = x / 2;
                }
            for (int i = stack.Count; i > 0; i--)
            {
                Console.Write("{0}", stack.Peek());
                stack.Pop();
            }

            Console.ReadLine();

        }

              
    }
}



//public static void BinaryToDecimal(int x)
//{
//    int b = x;
//    string r = " ";
//    //Changing r to string so we can print the number in reverse order that is from left to rightor we can use stack.
//    while (x > 0)
//    {
//        r = r + (x % 2).ToString();
//        // Console.Write(r);

//        x = x / 2;

//    }
//    //Printing the binary number from left to right
//    string temp = " ";
//    for (int i = r.Length - 1; i >= 0; i--)
//    {
//        temp = temp + r[i];

//    }

//    Console.WriteLine("Binary Representation of {0} is {1} ", b, temp);

//}
