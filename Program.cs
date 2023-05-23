using System.Text;

namespace Answer11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> words = new Stack<string>();
            string input= "The weather is so sunny nowadays\nLife is so beautiful";
            StringBuilder word=new StringBuilder();
            StringBuilder output=new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]==' ')
                {
                    words.Push(word.ToString());
                    word.Clear();
                }
                else if (input[i] == '\n')
                {
                    words.Push(word.ToString());
                    word.Clear();
                    while (words.Count > 0)
                    {
                        output.Append(words.Pop() + ' ');
                    }
                    output.AppendLine();
                }
                else
                {
                    word.Append(input[i]);
                }
            }
            if (word.Length>0)
            {
                words.Push(word.ToString());
                word.Clear();
            }
            while (words.Count > 0)
            {
                output.Append(words.Pop() + ' ');
            }
            Console.WriteLine(output.ToString());
        }
    }
}