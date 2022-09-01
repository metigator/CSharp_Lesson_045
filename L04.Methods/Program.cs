using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;

namespace Metigator45.L04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // RunAppend();
            // RunAppendJoin();
            // RunAppendFormat();
            // RunAppendLine();
            // RunInsert();
            // RunReplace();
            // RunRemove();
            // RunClear();
            // RunGetChuncks();
            // RunInsureCapacity();
            // RunCopyTo(); 
             RunCharAtIndex();
            Console.ReadKey();
        }

      

        private static void RunAppend()
        {
            var sb = new StringBuilder();
            // Append Return StringBuilder, useful method chaining
            sb.Append("ƒ(x)").Append("=").Append("Σ").Append("x²").Append("±").Append("α");

            Console.WriteLine(sb.ToString());
        }

        private static void RunAppendJoin()
        {
            string[] words = { "I", "Love", "Metigator" };
            var sb = new StringBuilder();
            sb.AppendJoin('°', words); 
            Console.WriteLine(sb.ToString());
        }

        private static void RunAppendFormat()
        {
            string customer = "Issam A";
            DateTime shippingDate = DateTime.Now; // yyyy-MM-dd hh:mm
            DateTime expectedDelivery = shippingDate.AddDays(7); // yyyy-MM-dd hh:mm
            decimal shippingCost = 29.99m;

            var sb = new StringBuilder();

            sb.AppendFormat(
                "\nDear {0}.," +
                "\n\nAt {1:t} on {1:D}, the order is on its way to you" +
                "\nIt's expected to be delivered at {2:t} on {2:D}, the order is on its way to you" +
                "\nShipping cost {3:c}." +
                "\n\t\t\tThanks for shopping with us!",

                customer, shippingDate, expectedDelivery, shippingCost);
            //   0           1              2                3
            Console.WriteLine(sb.ToString());
        }

        private static void RunAppendLine()
        {
            var sb = new StringBuilder();

            sb.AppendLine("C# is a modern, object-oriented, type-safe programming language");
            sb.AppendLine("C# enables developers to build secure and robust applications");
            sb.AppendLine("C# has its roots in the C family of languages "); 
            Console.WriteLine(sb.ToString());
        } 

        private static void RunInsert()
        { 
            var sb = new StringBuilder("C# is a modern, object-, type-safe programming language");
            
            sb.Insert(23, "oriented");

            Console.WriteLine(sb.ToString());
        }

        private static void RunReplace()
        {
            var sb = new StringBuilder();
           
            // Append Return StringBuilder, useful method chaining
            sb.Append("Fetigator");
          
            Console.WriteLine("before replace..");
            Console.WriteLine(sb.ToString());

            sb.Replace("Fetigator", "Metigator");

            Console.WriteLine("after replace.."); 
            Console.WriteLine(sb.ToString());
        }

        private static void RunRemove()
        {
            var sb = new StringBuilder();

            // Append Return StringBuilder, useful method chaining
            sb.Append("Metigator xyx");

            Console.WriteLine("before remove..");
            Console.WriteLine(sb.ToString());

            sb.Remove(9, 4);

            Console.WriteLine("after remove..");
            Console.WriteLine(sb.ToString());
        }

        private static void RunClear()
        {
            var sb = new StringBuilder();

            // Append Return StringBuilder, useful method chaining
            sb.Append("Metigator");

            Console.WriteLine("before clear..");
            Console.WriteLine(sb.ToString());

            sb.Clear();

            Console.WriteLine("after clear..");
            Console.WriteLine(sb.ToString());
        }

        private static void RunGetChuncks()
        {
            var sb = new StringBuilder();

            sb.Append("I Love Metigator");

            sb.Append("Youtube Channel");

            var counter = 1;
            foreach (var chunk in sb.GetChunks())
            {
                Console.WriteLine($"chunck #{counter++}: \"{chunk}\" length: {chunk.Length}");
            }
        }

        private static void RunInsureCapacity()
        {

            var sb = new StringBuilder(10);

            Console.WriteLine("before sb.EnsureCapacity(12)");
            Console.WriteLine(sb.Capacity); // 10

            Console.WriteLine("after ensuring capacity");

            // If the current capacity is less than the capacity
            // parameter, memory for this instance is reallocated
            // to hold at least capacity number of characters; otherwise,
            // no memory is changed.

            sb.EnsureCapacity(8);

            Console.WriteLine("after sb.EnsureCapacity(12)");
            Console.WriteLine(sb.Capacity); // 12



        }

        private static void RunCopyTo()
        {
            var sb = new StringBuilder("Metigator");
            char[] characters = new char[sb.Length];
            sb.CopyTo(0, characters, 0, sb.Length) ;
            Console.WriteLine(characters);
            
        }
        private static void RunCharAtIndex()
        {
            var sb = new StringBuilder("Metigator");
            var firstChar = sb[0];
            Console.WriteLine(firstChar);

        }

    }
}