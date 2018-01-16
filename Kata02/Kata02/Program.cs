using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata02
{
    class Program
    {
        private static void Main(string[] args)
        {
            InputString();
            CheckDuplicateValues(outputHashList);
            OutputList();
        }

        private static void OutputList()
        {
            for (int i = 0; i < outputHashList.Count; i++)
            {
                Console.WriteLine(outputHashList[i]);
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        private static void InputString()
        {
            string[] inputHashValues = new string[] {   "corey12345", "coreym1234", "core123456",
                                                        "Corey12345", "corey12345", "sarah543210",
                                                        "SARAH54321", " ", "1234567890" };

            for (int i = 0; i < inputHashValues.Length; i++)
            {
                CheckRuleSet(inputHashValues[i]);
            }
        }

        private static List<string> CheckDuplicateValues(List<string> outputList)
        {
            var distinctNames = (from d in outputList select d).Distinct(); 
            return outputHashList = distinctNames.ToList();
        }

        private static List<string> outputHashList = new List<string>();

        private static void CheckRuleSet (string inputHashValue)
        {
            var numberCount = 0;
            var letterCount = 0;
            var charValue = inputHashValue.ToCharArray();

            for (int i = 0; i < charValue.Length; i++)
            {
                if (Char.IsLetter(charValue[i]) && (Char.IsLower(charValue[i])))
                    letterCount++;
                if (Char.IsNumber(charValue[i]))
                    numberCount++;
            }
            if (numberCount == 5 && letterCount == 5)
                outputHashList.Add(inputHashValue);
        }
    }
}
