using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata00
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCaseStringInput = "jsdfasdf14"; 
            
            if (String.IsNullOrEmpty(testCaseStringInput))
                Console.WriteLine("Hash value empty");

            var countNumber = 0;
            var countLetter = 0;
            foreach (var item in testCaseStringInput.ToCharArray())
            {
                if (char.IsNumber(item))
                    countNumber++;
                
                if (char.IsLetter(item))
                    countLetter++;
            }
            List<string> output = new List<string>();
            //looping thru the array and adding [0]
            if (countNumber == 5 && countLetter == 5)
            {
                output.Add(testCaseStringInput);
            }
            else
                Console.WriteLine("No valid hash value found");

            Console.ReadLine(); 
        }
    }
}

//RULES: a valid hash value consists of five numbers and five lowercase letters in any order.
//Return an array of valid hash values, and eliminate any duplicates
