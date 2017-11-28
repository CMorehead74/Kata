using System;
using System.Collections.Generic;

namespace Kata00
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            //RULES: a valid hash value consists of five numbers and five lowercase letters in any order.
            //Return an array of valid hash values, and eliminate any duplicates

            string[] hashValue = new String[] { "asdfiasdfg", "jsdfasdf14", "a212sdf345", "as00yud567",
                "as34asd567", "agsdgreast", "1dfg23asd4", "hjkjw98076", "fdsqweqrah", "12gh34gh1g" };

            List<String> outputString = new List<String>();
            for (int i = 0; i < hashValue.Length; i++)
            {
                if (StringSort(hashValue[i]))
                {
                    outputString.Add(hashValue[i]);
                }
            }

            String[] outputHashValue = outputString.ToArray();

            for (int i = 0; i < outputHashValue.Length; i++)
            {
                Console.WriteLine(outputHashValue[i]);
            }

            Console.ReadLine();

            bool StringSort(string pHashValue)
            {
                if (String.IsNullOrEmpty(pHashValue))
                {
                    Console.WriteLine("Hash value empty");
                    return false;
                }
                var countNumber = 0;
                var countLetter = 0;
                foreach (var item in pHashValue.ToCharArray())
                {
                    if (char.IsNumber(item))
                        countNumber++;

                    if (char.IsLetter(item))
                        countLetter++;
                }
                if (countNumber == 5 && countLetter == 5)
                {
                    return true;
                }
                else
                    return false;
            }
        }
    }
}

