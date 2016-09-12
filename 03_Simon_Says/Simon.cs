using System;
using System.Globalization;


namespace _03_Simon_Says
{
    public class Simon
    {
        internal string StartOfWord(string v1, int v2)
        {
            return v1.Substring(0, v2);

        }

        internal string FirstWord(string v)
        {
            string[] s = v.Split();
            return s[0];
        }

        internal string Titleize(string v)
        {
            CultureInfo cultureInfo = new CultureInfo("en-US");
            TextInfo textInfo = cultureInfo.TextInfo;

            //Array contains word that should not be capitalized.
            string[] fy = { "and", "over", "the" };

            //inputs string v into a array. Using build in method spilt.
            string[] s = v.Split();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] != null)
                {
                    s[0] = textInfo.ToTitleCase(s[0]);
                }

                bool a = Array.Exists(fy, element => element == s[i]);
                if (a == false)
                {
                    s[i] = textInfo.ToTitleCase(s[i]);
                }

            }


            return string.Join(" ", s);

        }

        internal string Echo(string v)
        {
            
            return v = v.ToLower();

        }

        internal string Repeat(string v1, int v2)
        {
            string b = v1;
            string s = "";

            for (int i = v2; i > 0; i--)
            {

                s += b + " ";
            }

            return s.Trim();

        }

        internal string Shout(string v)
        {
            
            return v.ToUpper();

        }

        internal object Repeat(string v)
        {
            
            return v + " " + v;

        }
    }
}