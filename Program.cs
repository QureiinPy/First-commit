using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;


namespace Lesson1
{
    internal class Program
    {
        public static string Swap(string s)
        {
            string lstVowels = "euioa";
            char[] lstChar = s.ToCharArray();
            lstChar = lstChar.Select(c => lstVowels.Contains(c) ? char.ToUpper(c) : c).ToArray();
            return string.Concat(lstChar);
        }
        static void Main(string[] args)
            {
                Console.WriteLine(Swap("Hello Man"));
            }
        }   
}