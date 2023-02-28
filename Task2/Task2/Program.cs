namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Verilmis ededler siyahisinda reqemlerinin sayi 2-den boyuk olan ededlerin cemini tapan alqoritm
            int[] numbers = { 100, 2, 3, 4, 5, 172, 201, 99};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 99)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}