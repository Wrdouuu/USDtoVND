using System;

namespace USDTOVND
{
    class Program
    {

        static void Main(string[] args)
        {
            float USD;
            float VND;
            Console.WriteLine("Amount of USD= ");
            USD = float.Parse(Console.ReadLine());
            Console.WriteLine("USD to VND= "+ USD * 23000 +"d");
        }
    }
}
