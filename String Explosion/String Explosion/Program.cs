namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int explode = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>' && char.IsDigit(text[i + 1]))
                    explode += int.Parse(text[i + 1].ToString());
                
                else if (text[i] != '>' && explode > 0)
                {
                    text = text.Remove(i, 1);
                    explode--;
                    i--;
                }
            }
            Console.WriteLine(text);
        }
    }
}