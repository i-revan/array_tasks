namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Vermilmis ededler siyahisindaki en boyuk eded ve en kicik ededin ededi ortasini tapan alqoritm

            int[] numbers = { 12, 0, 5, 88, 24, -8 };
            int max = numbers[0];
            int min = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine((max + min) / 2);
        }
    }
}