/*using System;

   class Program
   {

       public static void Main(string[] args)
       {
           int n, m = 0, rem = 0;
           Console.Write("Enter the Number to check Prime: ");
           n = int.Parse(Console.ReadLine());
           m = n / 2;

               if (n % 2 == 0)
               {
                   Console.Write("Number is not Prime.");
                   rem = 1;

               }

           if(rem == 0)
               Console.Write("Number is Prime.");
       Console.ReadLine();
   }

   }
   */

/*using System;

class Program
{

    public static void Main(string[] args)
    {
        int n, m = 0, rem = 0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;

        if (n % 2 == 0)
        {
            Console.Write("Number is not Prime.");
            rem = 1;

        }

        else
        {
            Console.Write("Number is Prime.");
        }
        Console.ReadLine();
    }

}
*/
/*
using System;

class Program
{

    public static void Main(string[] args)
    {
        int n, m = 0, rem = 0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (int i = 2; i <= m; i++)
        {
            if (n % 2 == 0)
            {
                Console.Write("Number is not Prime.");
                rem = 1;

            }
        }

        if (rem == 0)
            Console.Write("Number is Prime.");
        Console.ReadLine();
    }

}
*/
/*

using System;
using System.Text;

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("enter the string");
        string s1 = Console.ReadLine();
        byte[] arr = Encoding.ASCII.GetBytes(s1);
        Console.Write("Ascii value of string");
        foreach (byte e in arr)
        {
            Console.WriteLine(" {0} = {1} ",e,  (char)e);
        }
        Console.ReadLine();
    } 

}*/

/*
using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.Write("enter the string");
        string s1 = Console.ReadLine();
        
        Console.Write("Ascii value of string");
        foreach (byte e in arr)
        {
            Console.WriteLine(" {0} = {1} ", e, (char)e);
        }
        Console.ReadLine();
    } 
    */
/*using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");// aman 
            string s1 = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                reverseString += s1[i];
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String : ");// aman 
        string name = Console.ReadLine();
        int length = name.Length;
        for (int i = name.Length - 1; i >= 0; i--)
        {
            Console.Write(name[i]);
        }
        
        Console.ReadLine();
    }
}*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a String : ");// aman 
        string name = Console.ReadLine();
        string name1 = name;
        string rev = "";
        int length = name.Length;
        for (int i = name.Length - 1; i >= 0; i--)
        {
            rev = rev + name[i];
        }
        if (name.Equals(name1))
        {
            Console.WriteLine("string is plandrom");

        }
        else
        {
            Console.WriteLine("string is not a plandrom");
        }

        Console.ReadLine();
    }
}
*/