using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a \n new line";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive"; // "@" symbol states to use back-slashes as regular backslash vs as an insertion operator.

            //string myString = String.Format("{0} = {1}", "First", "Second");
            //string myString = String.Format("{0} = {0}", "First", "Second");
            //string myString = String.Format("{1} = {0}", "First", "Second");

            //For currency format
            //string myString = String.Format("{0:C}", 123.45);

            //For number format, ex:( adds commas for bigger numbers).
            //string myString = string.Format("{0:N}", 123456789);
            //string myString = string.Format("Percentage {0:P}", .123);
            //To set the format Yourself:
            //string myString = string.Format("Phone Number: {0:(###) ###-###}", 1234567890);

            //choosing parts of string, from index 6 and on:
            //string myString = " That summer we took threes across the board ";
            //myString = myString.Substring(6);
            //choosing parts of string, from index 6 up to 14:
            //string myString = " That summer we took threes across the board ";
            //myString = myString.Substring(6, 14);

            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //myString = myString.Format("Length before: {0} -- Length after: {1}",
                //myString.Length,
                //myString.Trim(),Length);
            


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
;