
//// string reverse 


//// C# program to reverse a string using a for loop
using System;

class GFG
{

    public static string Reverse(string Input)
    {

        // Converting string to character array
        char[] charArray = Input.ToCharArray();

        // Declaring an empty string
        string reversedString = String.Empty;

        // Iterating the each character from right to left
        for (int i = charArray.Length - 1; i > -1; i--)
        {

            // Append each character to the reversedstring.
            reversedString += charArray[i];
        }

        // Return the reversed string.
        return reversedString;
    }

    // Driver code
    static void Main(string[] args)
    {
        Console.WriteLine(Reverse("GeeksForGeeks"));
        Console.ReadLine();
    }
}



//swap two number


//using System;
//public class SwapExample
//{
//    public static void Main(string[] args)
//    {
//        int a = 5, b = 10;
//        Console.WriteLine("Before swap a= " + a + " b= " + b);
//        a = a * b; //a=50 (5*10)      
//        b = a / b; //b=5 (50/10)      
//        a = a / b; //a=10 (50/5)    
//        Console.Write("After swap a= " + a + " b= " + b);
//    }
//}



//Even or Odd


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace check1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i;
//            Console.Write("Enter a Number : ");
//            i = int.Parse(Console.ReadLine());
//            if (i % 2 == 0)
//            {
//                Console.Write("Entered Number is an Even Number");
//                Console.Read();
//            }
//            else
//            {
//                Console.Write("Entered Number is an Odd Number");
//                Console.Read();
//            }
//        }
//    }
//}



//number ot word 



//using System;
//public class ConversionExample
//{
//    public static void Main(string[] args)
//    {
//        int n, sum = 0, r;
//        Console.Write("Enter the Number= ");
//        n = int.Parse(Console.ReadLine());
//        while (n > 0)
//        {
//            r = n % 10;
//            sum = sum * 10 + r;
//            n = n / 10;
//        }
//        n = sum;
//        while (n > 0)
//        {
//            r = n % 10;
//            switch (r)
//            {
//                case 1:
//                    Console.Write("one ");
//                    break;
//                case 2:
//                    Console.Write("two ");
//                    break;
//                case 3:
//                    Console.Write("three ");
//                    break;
//                case 4:
//                    Console.Write("four ");
//                    break;
//                case 5:
//                    Console.Write("five ");
//                    break;
//                case 6:
//                    Console.Write("six ");
//                    break;
//                case 7:
//                    Console.Write("seven ");
//                    break;
//                case 8:
//                    Console.Write("eight ");
//                    break;
//                case 9:
//                    Console.Write("nine ");
//                    break;
//                case 0:
//                    Console.Write("zero ");
//                    break;
//                default:
//                    Console.Write("tttt ");
//                    break;
//            }//end of switch      
//            n = n / 10;
//        }//end of while loop       
//    }
//}


////  Prime number 

//using System;
//namespace Demo
//{
//    class MyApplication
//    {
//        public static void Main()
//        {
//            int n = 5, a = 0;
//            for (int i = 1; i <= n; i++)
//            {
//                if (n % i == 0)
//                {
//                    a++;
//                }
//            }
//            if (a == 2)
//            {
//                Console.WriteLine("{0} is a Prime Number", n);
//            }
//            else
//            {
//                Console.WriteLine("Not a Prime Number");
//            }
//            Console.ReadLine();
//        }
//    }
//}




// multithreading   



//using System;
//using System.Threading;

//class Program
//{
//    static void Main()
//    {
//        // queue a work item to the thread pool
//        ThreadPool.QueueUserWorkItem(Worker, "Hello, world!");

//        // do some other work in the main thread
//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine("Main thread doing some work");
//            Thread.Sleep(100);
//        }

//        Console.WriteLine("Done");
//    }

//    static void Worker(object state)
//    {
//        string message = (string)state;

//        for (int i = 0; i < 10; i++)
//        {
//            Console.WriteLine(message);
//            Thread.Sleep(100);
//        }
//    }
//}


//   Reverse number 

//using System;
//public class ReverseExample
//{
//    public static void Main(string[] args)
//    {
//        int n, reverse = 0, rem;
//        Console.Write("Enter a number: ");
//        n = int.Parse(Console.ReadLine());
//        while (n != 0)
//        {
//            rem = n % 10;
//            reverse = reverse * 10 + rem;
//            n /= 10;
//        }
//        Console.Write("Reversed Number: " + reverse);
//    }
//}



// pattern   

//using System;

//public class Program
//{

//    public static void Main(string[] args)
//    {
//        for (int row = 8; row >= 1; --row)
//        {
//            for (int col = 1; col <= row; ++col)
//            {
//                Console.Write("*");
//            }

//            Console.WriteLine();
//        }
//    }
//}

//////********
////*******
////******
////*****
////****
////***
////**
//*



//using System;
//using System.Diagnostics;

//public class Program
//{

//    public static void Main(string[] args)
//    {
//        for (int row = 1; row <= 8; row++)
//        {
//            for (int col = 1; col <= row; col++)
//            {
//                Console.Write("*");
//            }

//            Console.WriteLine();
//        }
//    }
//}

//*
//**
//***
//****
//*****
//******
//*******
//********
//Press any key to continue . . .




//using System;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int val = 8;
//        int i, j, k;
//        for (i = 1; i <= val; i++)
//        {
//            for (j = 1; j <= val - i; j++)
//            {
//                Console.Write(" ");
//            }
//            for (k = 1; k <= i; k++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine("");
//        }
//        Console.ReadLine();
//    }
//}

//       *
//      **
//     ***
//    ****
//   *****
//  ******
// *******
//********





//using System;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int number = 7;

//        for (int i = 0; i < number; i++)
//        {
//            if (i == 0 || i == 6)
//            {
//                for (int j = 0; j < number; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }
//            if (i >= 1 && i <= 5)
//            {
//                for (int j = 0; j < number; j++)
//                {
//                    if (j == 0 || j == 6)
//                    {
//                        Console.Write("*");
//                    }
//                    else if (j >= 1 && j <= 5)
//                    {
//                        Console.Write(" ");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }

//    }
//}

//*******
//*     *
//*     *
//*     *
//*     *
//*     *
//*******
//Press any key to continue . . .






//using System;

//public class Program
//{
//    static void stars(int count)
//    {
//        for (int i = 0; i < count; ++i)
//            Console.Write("*");
//    }

//    static void spaces(int count)
//    {
//        for (int i = 0; i < count; ++i)
//            Console.Write(" ");
//    }
//    public static void Main(string[] args)
//    {

//        int n = 8;

//        for (int i = 0; i < n; ++i)
//        {
//            stars(i + 1);
//            spaces(n - i - 1);
//            stars(n - i + 1);
//            spaces(2 * i);
//            stars(n - i);
//            spaces(n - i - 1);
//            stars(i + 1);

//            Console.WriteLine();
//        }

//    }
//}

//*       *****************       *
//**      ********  *******      **
//***     *******    ******     ***
//****    ******      *****    ****
//*****   *****        ****   *****
//******  ****          ***  ******
//******* ***            ** *******
//**********              *********
//Press any key to continue . . .


