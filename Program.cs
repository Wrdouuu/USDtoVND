using System;

namespace USDTOVND
{
    class Program
    {

        static void Main(string[] args)
        {
            float usd;
            float vnd;
            Console.WriteLine("Amount of USD= ");
            usd = float.Parse(Console.ReadLine());
            vnd = usd * 23000;
            Console.WriteLine("USD to VND= "+vnd);
        }
    }
}
