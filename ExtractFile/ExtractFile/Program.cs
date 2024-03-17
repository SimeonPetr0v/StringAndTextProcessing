namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            int lastSlash = file.LastIndexOf('\\');
            int lastDot = file.LastIndexOf('.');
            string name = file.Substring(lastSlash + 1, lastDot - lastSlash - 1);
            string extension = file.Substring(lastDot + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}