using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace recursion_intro_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        //1
        //מבלי להריץ, מה יקרה אם נקרא לפונקציה הבאה

        static void f1()
        {
            f2();
            Console.WriteLine("finished f1");
        }

        static void f2()
        {
            f3();
            Console.WriteLine("finished f2");
        }

        static void f3()
        {
            Console.WriteLine("finished f3");
        }

        //stack vs heap - הסבירו

        //מה יקרה אם נקרא לפעולה הבאה? מה בדיוק יקרה
        static void overflow()
        {
            overflow();
        }

        //2
        //ממשו בצורה רקרוסיבית את הפונקציה הבאה המחשבת את עצרת המספר המתקבל

        static int Factorial(int n)
        {
            return 0;
            //base case
            //recusrsive case
        }

        //מה יוחזר עבור קריאה עם ערך 4? הראו מעקב 


        //3
        //ממשו בצורה רקרוסיבית את פונקציית החזקה המקבלת בסיס וחזקה

        static int Power(int a, int b) //implement
        {
            return 0;
            //base case
            //recusrsive case
        }
        //מה יוחזר עבור 2 בחזקת 3? הראו מעקב

        //4
        //ממשו בצורה רקרוסיבית את פונקציית פיבונאצ'י

        static int Fibonacci(int n) //1,1,2,3,5,8,13 (start from index 1)
        {
            return 0;
            //base case
            //recusrsive case
        }

        //במה שונה רקורסיה זו מהקודמות?
        //בצעו מעקב עבור 5. האם קיבלתם ערך נכון



        //5
        //Follow the below for n=3, what's the difference between Print_T and Print_H?

        static void Print_T(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                Print_T(n - 1);
            }
        }

        static void Print_H(int n)
        {
            if (n > 0)
            {
                Print_H(n - 1);
                Console.WriteLine(n);
            }
        }


        //6

        static bool What1(int[] a, int num, int n)
        {
            if (n < 0) return false;
            if (a[n] == num) return true;
            else return What1(a, num, n - 1);
        }
        //Follow with num=13, n=3, a=[44,13,7,18]
        //what does What1 do?
    }
}