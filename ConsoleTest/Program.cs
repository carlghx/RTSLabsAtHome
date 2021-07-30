using System;
using ClassLibrary;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This console app will call the functions and display the output, in case NUnit or Test Explorer are not working for some reason.");
            TestAboveAndBelow();
            TestStringRotate();

            Console.ReadLine();
        }

        static void TestAboveAndBelow()
        {
            Console.WriteLine("Calling AboveAndBelow with { 1, 5, 2, 1, 10 }, 6");
            ClassLibrary.AboveAndBelow.Find(new int[] { 1, 5, 2, 1, 10 }, 6, out int above, out int below);
            Console.WriteLine($"Above: {above}, Below: {below}");
        }
        static void TestStringRotate()
        {
            Console.WriteLine("Calling StringRotate with MyString, 2");
            var output = StringRotate.Rotate("MyString", 2);
            Console.WriteLine($"Output: {output}");
        }
    }
}
