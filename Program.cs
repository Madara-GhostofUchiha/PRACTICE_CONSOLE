// See https://aka.ms/new-console-template for more information
using System;
//public class program
//{
//    public static void Main(string[] args)
//    {
//        string str1;
//        string str2;

//        Console.WriteLine("Enter the First Name");
//        str1 = Console.ReadLine();

//        Console.WriteLine("Enter the Last Name");
//        str2 = Console.ReadLine();

//        Console.WriteLine("The Full Name is : {0} {1}", str1, str2);

//        Console.ReadLine();
//    }
//}
//--------------------------------------------------------------------------------
//2.To find the length of the string 
//public class program
//{
//    public static void Main(string[] args)
//    {
//        string str;

//        Console.WriteLine("Enter the string");
//        str = Console.ReadLine();

//        int length = str.Length;

//        Console.WriteLine("The length of the string {0} is {1}", str, length);
//    }
//}
//6.To reverse a string without reverse function
//using System;
//public class program
//{
//    public static void Main(string[] args)
//    {
//        string str, reversestring = "";
//        int length;
//        Console.WriteLine("Enter the string :");
//        str = Console.ReadLine();
//        length = str.Length - 1;
//        while (length >= 0)
//        {
//            reversestring = reversestring + str[length];
//            length--;
//        }
//        Console.WriteLine("The Reversed String is :{0}", reversestring);
//        Console.ReadLine();
//    }   

//}
namespace odd_or_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Please Enter A Number");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                Console.WriteLine("Even number");
                Console.Read();

            }
            else
            {
                Console.WriteLine("Odd number");
                Console.Read();
            }

        }
    }
}
