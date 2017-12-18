using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata01
{
    class Program
    {
        static void Main(string[] args)
        {
            //5 numbers (lowercase), 5 letter
            //return array no dups

            List<string> outputHashList = new List<string>();
            string[] hashVaules = new string[] { "asdfi12345", "jsdfasdf14" };
            //, "a212sdf345",
            //"as00yud567", "as34asd567", "agsdgreast", "1dfg23asd4",
            //"hjkjw98076", "fdsqweqrah", "12gh34gh1g", "Corey12345", "sarah54321"

            for (int i = 0; i < hashVaules.Length; i++)
            {

                String[] temp = CountingNumbersLetters(hashVaules[i]);
                outputHashList.Add(temp[0]);

                Console.WriteLine(outputHashList[i]);
            }
            Console.WriteLine("Enter any key to return");
            Console.ReadLine();
        }

        private static string CountingNumbersLetters(string hashValue)
        {
            return hashValue;
        }


        //private static String[] CountingNumbersLetters(string[] hashVaule)
        //{
        //    //loop thru each hashValue
        //    List<string> listofHashValues = new List<string>();
        //    foreach (var stringValue in hashVaule)
        //    {
        //        var letterCounter = 0;
        //        var numCounter = 0;
        //        var charValue = stringValue.ToCharArray();
        //        for (int i = 0; i < charValue.Length; i++)
        //        {
        //            if (Char.IsNumber(charValue[i]))
        //                numCounter++;
        //            if (Char.IsLetter(charValue[i]))
        //                letterCounter++;
        //        }
        //        if (numCounter == 5 && letterCounter == 5)
        //        {
        //            listofHashValues.Add(stringValue);
        //        }
        //        if (listofHashValues.Count() > 0)
        //        {
        //            Console.WriteLine(listofHashValues[0]); 
        //        }
        //        else
        //            Console.WriteLine("String is not valid");
        //    }
        //    return listofHashValues.ToArray<string>();
        //}
    }
}
