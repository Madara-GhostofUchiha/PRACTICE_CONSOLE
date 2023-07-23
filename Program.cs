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
using System;
public class program
{
    public static void Main(string[] args)
    {
        string Str, reversestring = "";
        int Length;
        Console.Write("Enter A String : ");
        Str = Console.ReadLine();
        Length = Str.Length - 1;
        while (Length >= 0)
        {
            reversestring = reversestring + Str[Length];
            Length--;
        }
        Console.WriteLine("Reverse  String  Is  {0}", reversestring);
        Console.ReadLine();
    }
}

