using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the string u want to summerize: ");
            var sentence = Console.ReadLine();

            Console.WriteLine("input number of characters u want to semmerize to: ");
            var maxLength = Convert.ToInt32(Console.ReadLine());

            var summary = StringUtility.SummarizeText(sentence, maxLength);
            Console.WriteLine(summary);
        }
    }

    public class StringUtility
    {
        public static string SummarizeText(string text, int maxlength)
        {
            if (text.Length < maxlength)
                return text;
            else
            {
                var words = text.Split(' ');
                var totalcharacters = 0;
                var summarywords = new List<string>();

                foreach (var word in words)
                {
                    summarywords.Add(word);
                    totalcharacters += word.Length + 1;
                    if (totalcharacters > maxlength)
                        break;
                }

                return String.Join(" ", summarywords) + "....";
            }
        }
    }
}
