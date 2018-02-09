using System;

namespace Romanizer {
    public class Romanizer
    {
        public string Romanize(int arabic)
        {
            if (arabic > 9999) throw new ArgumentException();
            String roman = new string('I', arabic);
            roman = roman.Replace("IIIII", "V");
            roman = roman.Replace("VV", "X");
            roman = roman.Replace("XXXXX", "L");
            roman = roman.Replace("LL", "C");
            roman = roman.Replace("CCCCC", "D");
            roman = roman.Replace("DD", "M");
            roman = roman.Replace("MMMMM", "U");
            roman = roman.Replace("LXXXX", "XC");
            roman = roman.Replace("IIII", "IV");
            roman = roman.Replace("VIV", "IX");
            roman = roman.Replace("XXXX", "XL");
            roman = roman.Replace("CCCC", "CD");
            roman = roman.Replace("CDC", "D");
            roman = roman.Replace("DCD", "CM");
            return roman;
        }
    }
}
