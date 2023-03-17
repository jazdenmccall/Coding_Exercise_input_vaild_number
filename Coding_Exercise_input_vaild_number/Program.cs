using System;


// Write a program and ask the user to enter a number.
// The number should be between 1 to 10.
// If the user enters a valid number, display "Valid" on the console.
// Otherwise, display "Invalid". (This logic is used a lot in applications
// where values entered into input boxes need to be validated.)


namespace Coding_Exercise_input_vaild_number;

public class Vaild
{
    public static void Main ()
    {
        while(true)
        {
            Console.WriteLine("Enter a number from 1-10 ");
            var input = Console.ReadLine();
            int vaild = Convert.ToInt32(input);
            if(vaild >= 1 && vaild <= 10)
            {
                Console.WriteLine("Congrulation you did it");
                break;
            }
            else
            {
                Console.WriteLine("Not Quite /n Please Try Again ");
            }

        }
    }
}