namespace Estrutura_Base.Services
{
    public class FibonacciService
    {
        public float CalculateFibonacci(float n)
        {
            if (n <= 1)
            {
                return n;
            }
            float a = 0, b = 1, sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }
    }
}

