using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Morzeovka
{
    internal class Znaky
    {
        Dictionary<string, string> překlad = new Dictionary<string, string>();
        private Znaky() 
        {
            překlad.Add("A", ".-");
            překlad.Add("B", "-...");
            překlad.Add("C", "-.-.");
            překlad.Add("D", "-..");
            překlad.Add("E", ".");
            překlad.Add("F", "..-.");
            překlad.Add("G", "--.");
            překlad.Add("H", "....");
            překlad.Add("CH", "----");
            překlad.Add("I", "..");
            překlad.Add("K", "-.-");
            překlad.Add("L", ".-..");
            překlad.Add("M", "--");
            překlad.Add("N", "-.");
            překlad.Add("O", "---");
            překlad.Add("P", ".--.");
            překlad.Add("Q", "--.-");
            překlad.Add("R", ".-.");
            překlad.Add("S", "...");
            překlad.Add("T", "-");
            překlad.Add("U", "..-");
            překlad.Add("V", "...-");
            překlad.Add("W", ".--");
            překlad.Add("X", "-..-");
            překlad.Add("Y", "-.--");
            překlad.Add("Z", "--..");
            překlad.Add("1", ".----");
            překlad.Add("2", "..---");
            překlad.Add("3", "...--");
            překlad.Add("4", "....-");
            překlad.Add("5", ".....");
            překlad.Add("6", "-....");
            překlad.Add("7", "--...");
            překlad.Add("8", "---..");
            překlad.Add("9", "----.");
            překlad.Add("0", "-----");
        }

        public string PrekladDoMorzeovky(string Latinka)
        {
            string source2 = "Textový řetězec";
            char[] result2 = source2.ToCharArray();
            foreach (char c in result2)
            {
                string morzeovka = c.ToString();
                Console.WriteLine(c.Key + " " + c.Value.Name);
            }
            
        }
    }
}
