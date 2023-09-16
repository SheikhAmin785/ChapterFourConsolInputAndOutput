using System;

namespace ChapterFourConsolInputAndOutput
{
    class Program
    {
        public static write(string format, object argo, object argo,.....)
        {
            return (format, argo);
        }

      
        static void Main(string[] args)
        {

            Console.WriteLine("{0,6}", 123);
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}", 12);
            Console.Write("{0,-6}", 123);
            Console.WriteLine("--end");



            string str = "hello world";
            Console.WriteLine("{0}", str);


            Console.WriteLine("str" + str);

            Console.WriteLine("Hello World");

            Console.WriteLine(5);
            Console.WriteLine(3.14159265358979);

            Console.WriteLine("I love");
            Console.Write("this ");
            Console.Write("Book!");

            int age = 26;
            Console.WriteLine("He is " + age + " years old.");



        }
    }
}

//Dir current directory
//Cd change directory
//mkdir create new directory
//type print file content 
//copy copy one file to another file
// console.in console.out console.error
// console.out.writeline("hello");
