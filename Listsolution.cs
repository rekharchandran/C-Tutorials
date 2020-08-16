﻿using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)



        // Write a program and continuously ask the user to enter different names, until the user presses Enter
        // (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        {

            
                 var names = new List<string>();

                 while (true)
                 {
                     Console.Write("Type a name (or hit ENTER to quit): ");

                     var input = Console.ReadLine();
                     if (String.IsNullOrWhiteSpace(input))
                         break;
                     names.Add(input);
                 }

                 if (names.Count > 2)
                     Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                 else if (names.Count == 2)
                     Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                 else if (names.Count == 1)
                     Console.WriteLine("{0} likes your post.", names[0]);
                 else
                     Console.WriteLine();

            


            /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.

            
            var numbers = new List<int>();

            while (numbers.Count < 5)

            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);


          


         // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        // include duplicates. Display the unique numbers that the user has entered.


          


            { 
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }

           

            //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).If the list is
            // empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            // the 3 smallest numbers in the list.

            {
                string[] elements;
                while (true)
                {
                    Console.Write("Enter a list of comma-separated numbers: ");
                    var input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        elements = input.Split(',');
                        if (elements.Length >= 5)
                            break;
                    }

                    Console.WriteLine("Invalid List");
                }

                var numbers = new List<int>();
                foreach (var number in elements)
                    numbers.Add(Convert.ToInt32(number));

                var smallests = new List<int>();
                while (smallests.Count < 3)
                {
                    // Assume the first number is the smallest
                    var min = numbers[0];
                    foreach (var number in numbers)
                    {
                        if (number < min)
                            min = number;
                    }
                    smallests.Add(min);

                    numbers.Remove(min);
                }

                Console.WriteLine("The 3 smallest numbers are: ");
                foreach (var number in smallests)
                    Console.WriteLine(number);
            }
        





    }


    }

}









