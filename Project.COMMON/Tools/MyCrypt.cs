using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project.COMMON.Tools
{
    public static class MyCrypt
    {
        //Created Date => 28/06/2022
        //Update Date => Null

        static public string Crypt(string value)
        {
            char[] charArray = { '?', '_', '-' };
            string hashedCode = "";

            foreach (char item in value)
            {
                int tempInt; int secInt;

                tempInt = Convert.ToInt32(item) + 8;

                if (tempInt > 0 && tempInt <= 50)
                {
                    secInt = tempInt + 3;
                    hashedCode += $"{secInt}{charArray[0]}";
                }
                else if (tempInt > 50 && tempInt <= 100)
                {
                    secInt = tempInt + 6;
                    hashedCode += $"{secInt}{charArray[1]}";
                }
                else if (tempInt > 100 & tempInt <= 150)
                {
                    secInt = tempInt + 9;
                    hashedCode += $"{secInt}{charArray[2]}";
                }
            }
            return hashedCode;
        }

        static public string DeCrypt(string value)
        {
            string deHashedCode = "";

            List<string> parts = Regex.Split(value, @"(?<=[?_-])").ToList();


            foreach (string item in parts)
            {
                int secInt = 0;

                if (item.Contains("?"))
                {
                    string element = item.TrimEnd('?');

                    int firstValue = Convert.ToInt32(element) - 3;
                    secInt = firstValue;
                }
                else if (item.Contains("_"))
                {
                    string element2 = item.TrimEnd('_');

                    int secondValue = Convert.ToInt32(element2) - 6;
                    secInt = secondValue;
                }
                else if (item.Contains("-"))
                {
                    string element3 = item.TrimEnd('-');

                    int thirdValue = Convert.ToInt32(element3) - 9;
                    secInt = thirdValue;
                }
                else { return deHashedCode; }

                int asciiCode = secInt - 8;
                string character = Convert.ToChar(asciiCode).ToString();
                deHashedCode += character;
            }
            return deHashedCode;
        }
    }
}
