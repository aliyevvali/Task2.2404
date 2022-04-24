using System;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Capit("ali aliyev"));
        }
        public static StringBuilder  Capit(this string text)
        {
            StringBuilder sb = new StringBuilder();
            
            text = text.Trim().ToLower();

            sb.Append(char.ToUpper(text[0]));


            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    sb.Append(text[i]);
                    sb.Append(char.ToUpper(text[i+1]));
                    i++;
                }
                else
                {
                    sb.Append(text[i]);
                }
            }
            return sb;
        }
    }
}
