using System;
using System.Collections.Generic;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); 
         
        bool running = true;
        while(running)
        {
        
        Console.Write("Enter number: ");    
        string numberStr = Console.ReadLine();
        int numberInt = int.Parse(numberStr);

            if(numberInt != 0)
            {
                numbers.Add(numberInt);        
            }
            else{
               
                int total = 0;
                int largestNumber = 0; 
                int smallestNumber = 1000; 
                
                for(int i = 0; i < numbers.Count; i++)
                {   
                    total += numbers[i];
                    if(numbers[i] > largestNumber)
                    {
                        largestNumber = numbers[i];
                    }
                    if(numbers[i] > 0 && numbers[i] < smallestNumber)
                    {
                        smallestNumber = numbers[i];
                    }
                }

                Console.WriteLine($"total: {total}");
                double average = (double)total / numbers.Count;
                Console.WriteLine($"Average: {average}");
                Console.WriteLine($"Largest Number: {largestNumber}");
                Console.WriteLine($"The smallest positive number is: {smallestNumber}");
                numbers.Sort();
                Console.WriteLine("The sorted list is:");

                foreach(int num in numbers)
                {
                    Console.WriteLine($"{num}");
                }
                running = false;
            }
           }
        }
    }
/*
 Enter number: 3
  Enter number: 5
  Enter number: 7
  Enter number: 3
  Enter number: 2
  Enter number: -1
  Enter number: -4
  Enter number: -8
  Enter number: 0
  The sum is: 7
  The average is: 0.875
  The largest number is: 7
*/