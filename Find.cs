using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    public class Find
    {
        public List<string> FindLongestWord(string text)
        {
            List<string> result = new List<string>();
            int lengthoflongestWord = 0;
            List<string> arrayText = new List<string>();

            //Remove punctuation from the text
            string rowText = new string((from c in text
                                         where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                                         select c).ToArray());

            arrayText = rowText.Split(' ').ToList();
            lengthoflongestWord = arrayText.Max(x => x.Length);

            for (int i = 0; i < arrayText.Count - 1; i++)
            {
                if (arrayText[i].Length == lengthoflongestWord)
                    result.Add(arrayText[i]);  
            }

            return result;
        }
    }
}
