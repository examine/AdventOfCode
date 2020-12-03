using System;
using System.IO;
using System.Collections.Generic;

namespace day1
{
    class Program
    {
        //I suck at git
        static void Main(string[] args)
        {            
            List<int> numbers = new List<int>();
            
            StreamReader inputReader = new StreamReader(@"input.txt");
            string inputBuffer;
            
            while ((inputBuffer = inputReader.ReadLine()) != null)
            {
                numbers.Add(int.Parse(inputBuffer));
            }            

            int Goal = 2020;            

            for (int firstNumber = 0; firstNumber < numbers.Count; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber < numbers.Count; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber < numbers.Count; thirdNumber++)
                    {
                        if (numbers[firstNumber] + numbers[secondNumber] + numbers[thirdNumber] == Goal)
                        {
                            var sum = numbers[firstNumber] * numbers[secondNumber] * numbers[thirdNumber];

                            Console.WriteLine(sum);                            
                            Console.WriteLine("--------------------------------------");
                            Console.WriteLine(numbers[firstNumber] * numbers[secondNumber] * numbers[thirdNumber]);
                        }
                    }

                }
            }                        
        }
    }
}
