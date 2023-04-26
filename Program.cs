namespace Numero_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 20;
            var y = 25;

            Console.WriteLine(Checker(x, y));
        }

        static bool Checker(int x, int y)
        {
            return x == 30 || y == 30 || (x + y) == 30;
            
        }
    }
}