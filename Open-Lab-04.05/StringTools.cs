using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string nasobenie = string.Empty;
            char[] charArr = orig.ToCharArray();
            foreach (char ch in charArr)
            {
                for (int i = 0; i < n; i++)
                {
                    nasobenie += ch;
                }
            }
            return new string(nasobenie);
        }
    }
}
