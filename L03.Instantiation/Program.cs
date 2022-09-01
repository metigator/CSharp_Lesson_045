using System;
using System.Text;
namespace Metigator45.L03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // RunConstructorOverLoad1();
            // RunConstructorOverLoad2();
            // RunConstructorOverLoad3();
            // RunConstructorOverLoad4();
            // RunConstructorOverLoad5();
             RunConstructorOverLoad6();

            Console.ReadKey();
        }

        static void RunConstructorOverLoad1()
        {
            // StringBuilder ();
            var sb = new StringBuilder();
            // string value in string.Empty
            // capacity is set to the implementation-specific default 


            sb.Append("Metigator");

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Length: {sb.Length}");
            Console.WriteLine($"Capacity: {sb.Capacity}");
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}");
        }
        static void RunConstructorOverLoad2()
        {
            // StringBuilder (int capacity);
            // capacity is less than zero ArgumentOutOfRangeException  
            // capacity is zero =  default will be taken
            // capacity is extended to the default capacity if it fits
            var sb = new StringBuilder(8);

            sb.Append("Metigator");

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Length: {sb.Length}"); // 9
            Console.WriteLine($"Capacity: {sb.Capacity}"); // 16
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}"); //21..
        }
        static void RunConstructorOverLoad3()
        {
            // StringBuilder (string? value);
            // If value is null, the new StringBuilder will contain the empty string 
            var sb = new StringBuilder("Metigator");

            Console.WriteLine(sb);
            Console.WriteLine($"Length: {sb.Length}");
            Console.WriteLine($"Capacity: {sb.Capacity}");
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}");
        }
        static void RunConstructorOverLoad4()
        {
            // StringBuilder (string? value, int capacity);
            // if capacity less than zero => ArgumentOutOfRangeException
            // additional allocation if the number of chars stored exceed capacity

            var sb = new StringBuilder("Metigator", 4);

            Console.WriteLine(sb);
            Console.WriteLine($"Length: {sb.Length}"); // 9
            Console.WriteLine($"Capacity: {sb.Capacity}");
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}");
        }
        static void RunConstructorOverLoad5()
        {
            // StringBuilder (int capacity, int maxCapacity);
            // if capacity less than zero => ArgumentOutOfRangeException
            // if maxcapacity less than one => ArgumentOutOfRangeException
            // if capacity is zero implementation default capacity is used 
            // if capacity exeeds max capacity ArgumentOutOfRangeException

            var sb = new StringBuilder(0, 9);
            sb.Append("Metigator");

            Console.WriteLine(sb);
            Console.WriteLine($"Length: {sb.Length}");  // 9
            Console.WriteLine($"Capacity: {sb.Capacity}"); // 9 
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}"); //9
        }
        static void RunConstructorOverLoad6()
        {
            // StringBuilder (string? value, int startIndex, int length, int capacity);
            // If capacity is zero, the implementation-specific default capacity
            // if capacity less than zero => ArgumentOutOfRangeException
            // additional allocation if the number of chars stored exceed capacity
            // startIndex+length is not a position within value.=> ArgumentOutOfRangeException 

            //                          01234567
            var sb = new StringBuilder("I Love Metigator", 7, 9, 9);


            Console.WriteLine(sb);
            Console.WriteLine($"Length: {sb.Length}"); // 9
            Console.WriteLine($"Capacity: {sb.Capacity}"); // 9
            Console.WriteLine($"MaxCapacity: {sb.MaxCapacity}"); // 2, 147,0000
        }
    }
}