using System;

namespace CG_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //I started by disecting the assignment. First I just need the user to type a number of a month so I had that appear on screen.
            //I needed the line that I wrote to appear so I used console.readline to prompt the user. 
            Console.Write("Please type the number of any month: ");
            string userValue = Console.ReadLine();
            string message = " ";

            //I can only use if or else one time but I can use else if as many times as I need to. This is how I will list all of the possible answers.
            if (userValue == "1")
                message = "January";

            //putting the uservalue == in parentheses allows the if to be acted upon. The value of january is assigned to message
            //I tried console.writeline and console.readline right after typing in january to make sure this code worked. now to repeat for each month
            //I am wondering if there is a way to DRY this?

            else if (userValue == "2")
                message = "February";

            else if (userValue == "3")
                message = "March";

            else if (userValue == "4")
                message = "April";

            else if (userValue == "5")
                message = "May";

            else if (userValue == "6")
                message = "June";

            else if (userValue == "7")
                message = "July";

            else if (userValue == "8")
                message = "August";

            else if (userValue == "9")
                message = "September";

            else if (userValue == "10")
                message = "October";

            else if (userValue == "11")
                message = "November";

            //trying something fun next :)
            else if (userValue == "12")
                message = "December - the best month!";

            else
                message = "That is not a month. Please try again.";

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
