using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //NULL
            //2. Number of vowels
            char[] vowels = "AEIOU".ToCharArray();
            //3. Number of consonants
            char[] consonants = "BCDFHJKLMNPQRSTVWXYZ".ToCharArray();

            //4. Number of upper case letters

            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<6; i++)
            {
                values.Add(0);
            }

            foreach (var j in input.ToUpper())
            {
                if (input == "*")
                {
                    break;
                }
                else if (vowels.Contains(j))
                {
                    values[0]++;
                }
                else if (j == '.' | j == '!' | j == '?')
                {
                    values[2]++;
                }

                else if (consonants.Contains(j))
                {
                    values[1]++;
                }
                else if (j == '*')
                {
                    break;
                }
            }

            Regex rxUpper = new Regex(@"[A-Z]");
            Regex rxLower = new Regex(@"[a-z]");

            foreach (var k in input)
            {
                if (rxUpper.IsMatch(k.ToString()) == true)
                {
                    values[3]++;
                }
                else if(rxLower.IsMatch(k.ToString()) == true)
                {
                    values[4]++;
                }
                else if(k == '*')
                {
                    break;
                }
            }



            return values;
        }
    }
}
