﻿using System;
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


            string[] hashVaules = new string[] {    "asdfi12345", "jsdfasdf14", "a212sdf345",
                                                    "as00yud567", "as34asd567", "agsdgreast",
                                                    "1dfg23asd4", "hjkjw98076", "fdsqweqrah",
                                                    "12gh34gh1g", "Corey12345", "sarah54321",
                                                    "corey12345", "Sarah54321", "corey12345" };

            for (int i = 0; i < hashVaules.Length; i++)
            {
                CountingNumbersLetters(hashVaules[i]);
            }
            for (int i = 0; i < outputHashList.Count; i++)
            {
                Console.WriteLine(outputHashList[i]);
            }

            Console.WriteLine("Enter any key to return");
            Console.ReadLine();
        }

        private static List<string> outputHashList = new List<string>();

        private static void CountingNumbersLetters(string hashValue)
        {
            var charValue = hashValue.ToCharArray();
            var letterCount = 0;
            var numCount = 0;
            for (int i = 0; i < charValue.Length; i++)
            {
                if (Char.IsLetter(charValue[i]) && Char.IsLower(charValue[i]))
                    letterCount++;
                if (Char.IsNumber(charValue[i]))
                    numCount++;
            }
            if (numCount == 5 && letterCount == 5)
                outputHashList.Add(hashValue);
        }
    }
}
