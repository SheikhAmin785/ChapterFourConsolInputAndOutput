using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFourConsolInputAndOutput
{
    class StandardNumericFormate
    {
        Console.WriteLine("{0:C2}", 123.456);
        Console.WriteLine("{0:D6}", -1234);
            Console.WriteLine("{0:E2}", 123);
            Console.WriteLine("{0:F2}", -123.456);
            Console.WriteLine("{0:N2}", 1234567.8);
            Console.WriteLine("{0:P}", 0.456);
            Console.WriteLine("{0:X}", 254);

    }
}
