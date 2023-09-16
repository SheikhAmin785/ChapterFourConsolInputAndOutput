using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFourConsolInputAndOutput
{
    class ReadingNumber
    {
        static void Main()
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", a);




            Console.Write("Enter a floating-point number: ");
            string line = Console.ReadLine();
            double number = double.Parse(line);
            Console.WriteLine("You entered: {0}", number);

        }
    }
}
