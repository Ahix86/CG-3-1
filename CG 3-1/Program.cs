using System;

namespace CG_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // promting the user to give a numbe of a month
            Console.Write("Hello, please type the number of a month: ");
            string userValue = Console.ReadLine();
            string message = "";

            // initially I had curly braces after EVERY if or else if stament, arund the message line. After class I learned we didn't need to do that so i deleted them
            // below code does all the 'math' of turning the number they gave into the month it corresponds with

            if (userValue == "1")
            
                message = "January";
            
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
            
            else if (userValue == "12")
            
                message = "December";
            
                    else
             
                message = "Please select a number between 1 and 12.";
            
            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}





     

        
