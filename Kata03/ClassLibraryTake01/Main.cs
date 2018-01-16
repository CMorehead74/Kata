using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTake01
{
    public class Main
    {
        public void Input()
        {
            string[] inputHashValues = { "corey12345", "coreym1234", "Corey12345", "core123456" };
            for (int i = 0; i < inputHashValues.Length; i++)
            {
                CheckRuleSet(inputHashValues[i]);
            }
        }

        //duplicate

        //output

        public List<string> outputHashValue = new List<string>();

        public bool CheckRuleSet(string v)
        {
            var letterCount = 0;
            var numberCount = -0;
            var charHash = v.ToCharArray();

            for (int i = 0; i < charHash.Length; i++)
            {
                if (char.IsLetter(charHash[i]) || char.IsLower(charHash[i]))
                    {
                    letterCount++;
                    }
                if (char.IsNumber(charHash[i]))
                {
                    numberCount++;
                }
            }

            if (letterCount == 5 && numberCount == 5)
            {
                outputHashValue.Add(v);
                return true;
            }
            return false;
        }
    }
}
