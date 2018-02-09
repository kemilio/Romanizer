using RomanNumeralsGUI;
using System;
using System.Windows.Forms;

namespace Romanizer
{   // This program will take either a string or an integer as a parameter and return
    // an arabic number (string) or a roman numeral (integer)
    public class Numerals
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RomanizerForm());
        }
        /* Converts an arabic number to a roman numeral
         * @param: arabic -- the number (integer) to be converted
         * @returns: romanNumStr -- the roman numeral (string)
         */
        public static string Romanize(int arabic)
        {
            if (arabic > 9999) { throw new ArgumentException(); }
            var roman = new string('I', arabic);
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

        /* Converts a roman numeral to an arabic number
         * @param: roman(str) -- the numeral to be converted
         * @returns: arabicNum(int) -- the arabic number
         */
        public static int Deromanize(string roman)
        {
            roman = roman.Replace("U", "MMMMM");
            roman = roman.Replace("CD", "CCCC");
            roman = roman.Replace("CM", "CCCCCCCCC");
            roman = roman.Replace("M", "CCCCCCCCCC");
            roman = roman.Replace("D", "CCCCC");
            roman = roman.Replace("XC", "XXXXXXXXX");
            roman = roman.Replace("C", "LL");
            roman = roman.Replace("XL", "XXXX");
            roman = roman.Replace("L", "XXXXX");
            roman = roman.Replace("X", "VV");
            roman = roman.Replace("IV", "IIII");
            roman = roman.Replace("V", "IIIII");
            var arabic = roman.Length;
            roman = roman.Replace("I", "");
            if (roman.Length != 0) { throw new ArgumentException(); }
            return arabic;
        }
    }
}
