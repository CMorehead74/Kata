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
            //TODO:
            //take those 10 symbols and call function that will  verify RULES and remove dupicates

            //RULES: a valid hash value consists of five numbers and five lowercase letters in any order.
            //Return an array of valid hash values, and eliminate any duplicates

            string[] hashValue = new String[] { "asdfiasdfg", "jsdfasdf14", "a212sdf345", "as00yud567", "as34asd567", "agsdgreast", "1dfg23asd4", "hjkjw98076", "fdsqweqrah", "12gh34gh1g" };

            for (int i = 0; i < hashValue.Length; i++)
                StringSort(hashValue[i]);

            //TODO:
            //output list of string items

            List<string> StringSort(string pHashValue)
            {
                if (String.IsNullOrEmpty(pHashValue))
                    Console.WriteLine("Hash value empty");

                var countNumber = 0;
                var countLetter = 0;
                foreach (var item in pHashValue.ToCharArray())
                {
                    if (char.IsNumber(item))
                        countNumber++;

                    if (char.IsLetter(item))
                        countLetter++;
                }
                List<string> output = new List<string>();
                //TODO:
                //looping thru the inputArray and adding index to the outputArray
                if (countNumber == 5 && countLetter == 5)
                {
                    output.Add(pHashValue);
                }
                else
                    Console.WriteLine("No valid hash value found");

                Console.ReadLine();

                return output;
            }
        }
    }
}

