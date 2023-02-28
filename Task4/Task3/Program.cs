using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Verilmis adlar siyahisindaki adi 'A' herfi ile baslayanlarin sayini tapan alqoritm
            string[] names = { "Adil", "Teymur", "Səlim", "Samirə", "Almaz", "Ali"};
            int count = 0;
            for(int i = 0; i < names.Length; i++)
            {
                if (names[i][0] == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}