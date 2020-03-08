using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text =
                "The longest word in any of the major English language dictionaries is 9pneumonoultramicroscopicsilicovolcanoconiosis, " +
                "a word that refers to a lung disease contracted from the inhalation of very fine silica particles, " +
                "specifically from a volcano; medically, it is the same as silicosis.";

            Find Search = new Find();

            List<string> result = Search.FindLongestWord(text);

            Console.WriteLine("The longest word(s) in the text");

            foreach (var item in result)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
