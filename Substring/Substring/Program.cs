namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()
                .ToLower();
            string input = Console.ReadLine();
            CheckAndRemove(input, word);
        }

        static void CheckAndRemove(string input, string keyword)
        {
            int index = input.IndexOf(keyword);
            while (index != -1)
            {
                input = input.Remove(index, keyword.Length);
                index = input.IndexOf(keyword);
            }
            Console.WriteLine(input);

        }
    }
}