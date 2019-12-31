using System;

namespace NumberUtil
{
    public static class PolynomialX
    {
        public static int Polynomial(this int[] coefficients, int x)
        {
            var n = (coefficients == null) ? 0 : coefficients.Length;
            
            if (n == 0) return 0;

            var retVal = 0;
            for (int i = n - 1, exp = 0; i >= 0; i--, exp++)
            {
                if (i == n - 1)
                {
                    retVal += coefficients[i];
                }
                else if (i == n - 2)
                {
                    retVal += coefficients[i] * x;
                }
                else
                {
                    retVal += coefficients[i] * (int)Math.Pow(x, exp);
                }
            }

            return retVal;
        }

    }

}
