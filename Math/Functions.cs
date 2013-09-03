namespace Math
{
    public class Functions
    {
        public static int Factorial(int x)
        {
            return x <= 1 ? 1 : x * Factorial(x - 1);
        }
    }
}
