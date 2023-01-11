using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PRG_Morzeovka
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
        private static Dictionary<String, String> opačně = new Dictionary<String, String>();

        public string PrekladDoMorzeovky(string txt)
        {
            string normalizedText = txt.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            foreach (var x in normalizedText)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(x) != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(x);
                }
            }
            string vysledek = "";
            string neco = sb.ToString();
            char[] result2 = neco.ToCharArray();
            List<String> konec = new List<string>();
            foreach (char c in result2)
            {
                string morzeovka = c.ToString();
                konec.Add(překlad[c.ToString()]);
            }
            vysledek = string.Join("/", konec);
            vysledek = vysledek.Replace("/-.-./..../", "/----/");
            return vysledek;
        }
        public string PrekladDoLatinky(string txt)
        {
            string[] znaky = ToSymbols(txt);
            string vysledek = "";
            foreach (string a in znaky)
            {
                vysledek += opačně[a];
            }

            return vysledek;
        }
        private static string[] ToSymbols(string txt)
        {
            return txt.Split("/");
        }
        private static char[] ToChars(string txt)
        {
            return txt.ToCharArray();
        }
        private static string Normalizuj(string txt)
        {
            txt = txt.ToUpper();
            string normalizedText = txt.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            foreach (var x in normalizedText)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(x) != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(x);
                }
            }
            txt = sb.ToString().Normalize(NormalizationForm.FormC);
            return txt;
        }

    }
}