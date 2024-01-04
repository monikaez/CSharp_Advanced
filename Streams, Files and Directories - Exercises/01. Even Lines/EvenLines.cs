namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using StreamReader streamReader = new(inputFilePath);

            string line = string.Empty;
            int count = 0;

            StringBuilder sb = new();

            while (line != null)
            {
                line = streamReader.ReadLine();

                if (count % 2 == 0)
                {
                    string replaceSymbols = ReplaceSymbols(line);

                    string reverseWord = ReverseWords(replaceSymbols);

                    sb.AppendLine(reverseWord);
                }
                count++;
            }
            return sb.ToString();
        }

        private static string ReverseWords(string words)
        {
            string[] reversedWords = words.
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", reversedWords);
            
        }

        private static string ReplaceSymbols(string text)
        {
            StringBuilder sb = new(text);
            char[] symbolToReplace = { '-', ',', '.', '!', '?' };

            foreach (char symbol in symbolToReplace)
            {
                sb = sb.Replace(symbol, '@');
            }
            return sb.ToString();
        }
    }
}
