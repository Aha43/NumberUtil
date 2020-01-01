namespace NumberUtil
{
    public static class ClosedFormsX
    {
        public static int SumOfNumbers(this int n) => n * (n + 1) / 2;
        public static long SumOfNumbers(this long n) => n * (n + 1) / 2;

        public static int SumOfSquares(this int n) => n * (n + 1) * (2 * n + 1) / 6;
        public static long SumOfSquares(this long n) => n * (n + 1) * (2 * n + 1) / 6;

    }

}
