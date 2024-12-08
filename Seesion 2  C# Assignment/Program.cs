using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Seesion_2__C__Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 2 

            #region 1-Write a program that allows the user to enter a number then print it.

            //Console.Write("Please Enter A Number : ");
            //int Number = int.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.WriteLine($"Your Number : {Number}");
            #endregion

            #region 2-Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //Console.Write("Enter A String To Convert To Integer : ");
            //string? Text = Console.ReadLine();

            //int TextTOInteger;
            //bool IsParsed = int.TryParse(Text, out TextTOInteger);

            //if (IsParsed == false)
            //{

            //    Console.WriteLine("Error: The text contains non-strong characters and cannot be converted to an integer.");
            //}
            //else
            //{
            //    Console.WriteLine($"String To Convert To Integer : {TextTOInteger}");
            //}

            ////Note : If the string contains only numbers, the conversion will be done without any problem. However, if the string contains letters, the conversion will not be done.


            #endregion

            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //Console.Write("Enter the First Number : ");
            //double num1 = double.Parse(Console.ReadLine() ?? "0");

            //Console.Write("please Enter The Type Of Operation (+ , -  , / , * )   : ");
            //string? Operation = Console.ReadLine();

            //Console.Write("Enter the Second Number : ");
            //double num2 = double.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();

            //if (Operation == "+")
            //{ 
            //    Console.WriteLine($" {num1} + {num2} = {num1 + num2}");
            //}
            //else if (Operation == "-")
            //{
            //    Console.WriteLine($" {num1} - {num2} = {num1 - num2}");
            //}
            //else if (Operation == "*")
            //{ 
            //    Console.WriteLine($" {num1} × {num2} = {num1 * num2}");
            //}
            //else if (Operation == "/")
            //{
            //    Console.WriteLine($" {num1} ÷ {num2} = {num1 / num2}");
            //}
            //else {
            //    Console.WriteLine("Invalid Operation Type");
            //     }
            #endregion

            #region 4-Write C# program that Extract a substring from a given string.

            //Console.Write("Enter A string: ");
            //string? Text = Console.ReadLine();

            //Console.WriteLine("Extraction Starts From Letter: ");
            //int LetterNum1 = int.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine("To Letter: ");
            //int LetterNum2 = int.Parse(Console.ReadLine() ?? "0");

            //string SubString = Text.Substring(LetterNum1, LetterNum2 - LetterNum1);
            //Console.WriteLine($"Extract a substring: {SubString}");

            #endregion

            #region 5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            ////Declare and initialize a value type variable
            //int X = 10;
            //// Assign the value of originalValue to another variable
            //int Y  = X;
            //Console.WriteLine($"X : {X}"); // print : 10
            //Console.WriteLine($"Y: {Y}");     // print : 10

            //// Modify Y
            //Y = 20;
            //Console.WriteLine("After modifying Y :");
            //Console.WriteLine($"X : {X}"); // Print: 10
            //Console.WriteLine($"Y : {Y}"); //Print : 20
            #endregion

            #region 6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Point obj1= new Point();
            //obj1.value = 5;
            //Point obj2 = obj1;
            //obj2.value = 6;

            //Console.WriteLine(obj1.value);
            //Console.WriteLine(obj2.value);

            ////Note : Any Change That Occurs In  'obj2 ' Will be Reflected In 'obj1' Becouse The Reference Type .

            #endregion

            #region 7-Write C# program that take two string variables and print them as one variable 
            //string text1 = "Hallo";
            //string text2 = "World";
            //Console.WriteLine($"Combined String : {text1}  {text2}");

            #endregion

            #region 8-Which of the following statements is correct about the C#.NET code snippet given below?
            /*
            int d;
            d = Convert.ToInt32(!(30 < 20));
            */

                // a)A value 0 will be assigned to d.
                // b)A value 1 will be assigned to d.
                // c)A value -1 will be assigned to d.
                // d)The code reports an error.
                // e)The code snippet will work correctly if ! is replaced by Not.


            // The Answer :  b)A value 1 will be assigned to d.
            #endregion

            #region 9-Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
                //a)6.5 1
                //b)6.5 0
                //c)6 0
                //d)6 1
                //e)6.5 6.5



            // The Answer : d)6 1
            #endregion

            #region 10-What will be the output of the C# code given below?
            /*
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            */
                 //a) 5 6
                 //b) 6 5
                 //c) 6 6
                 //d) 7 7

            // The Answer :  d) 7 7
            #endregion


        }
    }
}
