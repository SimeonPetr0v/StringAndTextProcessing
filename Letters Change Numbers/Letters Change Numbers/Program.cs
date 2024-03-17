namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Calculations = Console.ReadLine().Split();
            int result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (string calculation in Calculations)
            {
                int calcNum = getNums(calculation);
                if (calculation[0] == calculation.ToLower()[0])
                    alphabet.IndexOf(calculation[0]);
                else
                    calcNum /= alphabet.IndexOf(calculation[0]);
                if (calculation[calculation.Length - 1] == calculation.ToLower()[calculation.Length-1])
                    calcNum += alphabet.IndexOf


            }
        }
        
    }
    static int getNums (string calculation)
    {
        int result = 0;
        foreach(char c in calculation)
        {
            if (char.IsDigit(c))
            {
                result += c;
            }
        }
        return result;
    }
}