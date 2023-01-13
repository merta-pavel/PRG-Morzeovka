using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Morzeovka
{
    internal class Znaky
    {
        private static Dictionary<String, String> překlad = new Dictionary<String, String>()
            {
                {"A" , ".-"},
                {"B" , "-..."},
                {"C" , "-.-."},
                {"D" , "-.."},
                {"E" , "."},
                {"F" , "..-."},
                {"G" , "--."},
                {"H" , "...."},
                {"I" , ".."},
                {"J" , ".---"},
                {"K" , "-.-"},
                {"L" , ".-.."},
                {"M" , "--"},
                {"N" , "-."},
                {"O" , "---"},
                {"P" , ".--."},
                {"Q" , "--.-"},
                {"R" , ".-."},
                {"S" , "..."},
                {"T" , "-"},
                {"U" , "..-"},
                {"V" , "...-"},
                {"W" , ".--"},
                {"X" , "-..-"},
                {"Y" , "-.--"},
                {"Z" , "--.."},
                {"0" , "-----"},
                {"1" , ".----"},
                {"2" , "..---"},
                {"3" , "...--"},
                {"4" , "....-"},
                {"5" , "....."},
                {"6" , "-...."},
                {"7" , "--..."},
                {"8" , "---.."},
                {"9" , "----."},
            };

        public static string PrekladDoMorzeovky(string txt)
        {

            txt = Normalize(txt);
            char[] znaky = ToChars(txt);
            string konec = "";
            List<String> vysledek = new List<string>();
            foreach (char c in znaky)
            {
                vysledek.Add(překlad[c.ToString()]);
            }
            konec = string.Join("/", vysledek);
            konec = konec.Replace("/-.-./..../", "/----/");
            return konec;
        }
        public static string PrekladDoLatinky(string latinka)
        {
            var retezec = new StringBuilder();
            var opacne = překlad.ToDictionary(x => x.Value, x => x.Key);
            latinka = latinka.Trim();
            var znaky = latinka.Split("/");


            foreach (string a in znaky)
            {
                retezec.Append(opacne[a]);
            }
            return retezec.ToString();
        }
        private static char[] ToChars(string charA)
        {
            return charA.ToCharArray();
        }
        private static string Normalize(string Normalize)
        {
            Normalize = Normalize.ToUpper();
            string normalizedText = Normalize.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            foreach (var x in normalizedText)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(x) != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(x);
                }
            }
            Normalize = sb.ToString().Normalize(NormalizationForm.FormC);
            return Normalize;
        }
        private static string[] ToSymbols(string Symbols)
        {
            return Symbols.Split("/");
        }
    }
}