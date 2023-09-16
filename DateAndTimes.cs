using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFourConsolInputAndOutput
{
    class DateAndTimes
    {
        DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
        Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
        Console.WriteLine("{0:d.MM.yy}", d);


    }
}

//specifier   formate
  //d      =   9/17/2023
 // D      =   February 27,2012
  //t      =   17.30(hour)
 // T      =   17:30:22 (hour)
  //Y      =   February 2012