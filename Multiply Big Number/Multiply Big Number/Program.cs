namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            int c = 0;
            string res = "";

            for (int i = n1.Length - 1; i >= 0; i--)
            {
                int singleDigit = n1[i] - '0';
                int final = singleDigit * n2 + c;
                c = final / 10;
                res = (final % 10) + res;
            }

            if (c > 0)
            {
                res = c + res;
            }
            res = res.TrimStart('0');
            Console.WriteLine(res);
        }
    }
}