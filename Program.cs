using System;
namespace ForLoopDersi;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please intput a value: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i <= n; i++)
        {
            string spaces = new string(' ',n - i);
            string hashes = new string('#',i);
            Console.WriteLine(spaces+hashes);
        }
    }
}