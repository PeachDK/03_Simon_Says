using System;

namespace _03_Simon_Says
{
    public class Simon
    {
        internal string StartOfWord(string v1, int v2)
        {            
            return v1.Substring(0,v2);            
         
        }

        internal string FirstWord(string v)
        {           
            string[] s = v.Split();
            return s[0];
        }

        internal string Titleize(string v)
        {
            throw new NotImplementedException();
        }

        internal string Echo(string v)
        {
            string b = v.ToLower();
            return b;

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
            string b = v.ToUpper();
            return b;

        }

        internal object Repeat(string v)
        {
            string b = v;
            return b + " " + b;

        }
    }
}