namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Verilmis ededler siyahisindaki 3-e bolunen ededlerin ededi oratsini tapan alqoritm

            int[] numbers = { 1, 2, 3, 4, 5, 21 };
            int sum = 0;
            int count = 0;
            for (int  i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            Console.WriteLine(sum/count);
        }
    }
}