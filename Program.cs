namespace SumOfPrimeNumbers
{
    public class Program
    {
        static bool IsPrime(int num)
        {
            int i;
            if (num == 1)
            {
                Console.WriteLine("It is Not Prime Number");
            }
            for (i = 2; i <= num/2; i++)
            {

                if (num % i == 0)
                {
                    Console.WriteLine("not prime number");
                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            int start = 1, end = 10;
            int sum = 0;
            for (int num = start; num <= end/2; num++)
            {
                if (IsPrime(num))
                {
                    sum += num;
                }
            }
            Console.WriteLine("The sum of prime numbers between{0} and {1}is :{2}", start, end, sum);
        }
    }
}
        