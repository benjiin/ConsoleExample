using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExampleForBenny
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteBorder("Hallo Welt");
            Console.ReadLine();
        }

        static void WriteBorder(string text)
        {
            for (int i = 0; i < 30; i++)
            {
                WriteOnPos("#", i + 5, 5);
                WriteOnPos("#", i + 5, 15);
            }

            for (int i = 0; i < 10; i++)
            {
                WriteOnPos("#", 5, i + 5);
                WriteOnPos("#", 34, i + 5);
            }

            WriteOnPos(text, 15, 10);
        }
        static void WriteOnPos(string s, int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(s);
        }
    }
}
