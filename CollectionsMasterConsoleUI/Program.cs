using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays

            //DONE TODO: Create an integer Array of size 50
            var numberList = new int[50];

            //DONE TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            // Random randomNumber = new Random();
            // int number = randomNumber.Next(50);
            Populater(numberList);

            //DONE TODO: Print the first number of the array
            Console.WriteLine("Here is the first number in the array:");
            Console.WriteLine($"{numberList[0]}");

            //DONE TODO: Print the last number of the array    
            Console.WriteLine("Here is the LAST number in the array:");
            Console.WriteLine(($"{numberList[numberList.Length-1]}"));
            //Console.WriteLine($"{numberList[49]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            Console.WriteLine("Here is the list of all original numbers: ");
            NumberPrinter(numberList);
            Console.WriteLine("-------------------");

            //SKIP THIS TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____();
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            // Console.WriteLine("All Numbers Reversed:");
            //
            // Console.WriteLine("---------REVERSE CUSTOM------------");
            //
            // Console.WriteLine("-------------------");

            //DONE TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numberList);

            Console.WriteLine("-------------------");

            //DONE TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(numberList);
            NumberPrinter(numberList);

            Console.WriteLine("\n************End Arrays*************** \n");

            #endregion

            #region Lists

            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //DONE TODO: Create an integer List
            List<int> myList = new List<int>();
            
            //DONE TODO: Print the capacity of the list to the console
            Console.WriteLine($"Beginning Capacity: {myList.Capacity}");

            //DONE TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);

            //DONE TODO: Print the new capacity
            Console.WriteLine($"New capacity: {myList.Capacity}");

            Console.WriteLine("---------------------");

            //DONE TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            
            int userInput;
            bool isNumber;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userInput);
            } while (isNumber == false);
            
            NumberChecker(myList, userInput);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //DONE UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //DONE TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            
            OddKiller(myList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            NumberPrinter(myList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var myArray = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            #endregion
        }
        

        //TODO: Create a method that will remove all odd numbers from the list then print results
        private static void OddKiller(List<int> myList)
        {
            for(int i = 0; i < 64; i++)
            {
                if (i % 2 != 0)
                    myList.Remove(i);
            }
            NumberPrinter(myList);
           
        }

        private static void NumberChecker(List<int> myList, int userInput)
        {
            if (myList.Contains(userInput))
            {
                Console.WriteLine($"That number IS IN the list.");
            }
            else
            {
                Console.WriteLine($"That number IS NOT in the list.");
            }
        }

        private static void Populater(int[] numberList)
        {
            for (int i = 0; i < numberList.Length; i++)
            {
                Random rng = new Random();
                numberList[i] = rng.Next(0, 50);
            }
        }
        
        private static void NumberPrinter(int[] numberList)
        {
            for (int i = 0; i <= numberList.Length-1; i++)
            {
                Console.WriteLine(numberList[i]);
            }
        }

        private static void ThreeKiller(int[] numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                if (numberList[i] % 3 == 0)
                {
                    numberList[i] = 0;
                }
                NumberPrinter(numberList);
            }
            
        }

        private static void Populater(List<int> myList)
        {
            while (myList.Count < 51)
            {
                Random randomNumber = new Random();
                var number = randomNumber.Next(0, 50);
                myList.Add(number);
            }
            NumberPrinter(myList);
            
        }

        private static void SortedNumbers(int[] myList)
        {
            for (int i = 0; i < 64; i++)
            {
                
            }
        }
        

        // private static void ReverseArray(int[] array)
        // {
        //
        // }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}


