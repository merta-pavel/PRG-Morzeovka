using Morzeovka;
/*// spojení znaků do řetězce
using System.Text;

char[] source1 = new char[] { 'A', 'B', 'C' };
string result1 = new string("source");

// rozdělení řetězce do znaků

string charA = "Textový řetězec";
char[] result2 = charA.ToCharArray();
// překódování z UTF-8 do ASCII (nefunguje tak, jak bychom potřebovali)
Encoding srcEnc = Encoding.UTF8;
Encoding dstEnc = Encoding.ASCII;

string txt = "Takový hezoučký den.";
var srcBytes = srcEnc.GetBytes(txt);
var dstBytes = Encoding.Convert(srcEnc, dstEnc, srcBytes);
string des = dstEnc.GetString(dstBytes);
Console.WriteLine(des);

// odstranění diakritiky
string Normalize = "Šílená čivava";
string normalizedText = txt.Normalize(NormalizationForm.FormD);
StringBuilder sb = new StringBuilder();
foreach (var x in normalizedText)
{
    if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(x) != System.Globalization.UnicodeCategory.NonSpacingMark)
    {
        sb.Append(x);
    }
}
Console.WriteLine(sb.ToString().Normalize(NormalizationForm.FormC));
// rozdělení řetězce na podřetězce podle určitého znaku
string[] Symbols = txt.Split("/");
// spojení znaků do řetězce s využitím oddělovače
string[] symbols = new string[] { "...", "---", "..." };
string res = string.Join("/", Symbols);

Console.WriteLine(res);
// převod znaků na malé znaky
Console.WriteLine(txt.ToLower());

// převod znaků na velké znaky
string neco = "Šílená čivava";
Console.WriteLine(Normalize.ToUpper());
*/

Console.WriteLine(Znaky.PrekladDoLatinky(".-"));
Console.WriteLine(Znaky.PrekladDoMorzeovky("MŇAMKA"));


