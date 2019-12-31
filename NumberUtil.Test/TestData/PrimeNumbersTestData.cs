using System.Collections;
using System.Collections.Generic;

namespace NumberUtil.Test.PrimeNumbers
{
    public class PrimeNumbersTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            int N = 105;
            for (int i = 0; i < 105; i++)
            {
                switch (i)
                {
                    case 2: 
                    case 3: 
                    case 5:
                    case 7:
                    case 11:
                    case 13:
                    case 17:
                    case 19:
                    case 23:
                    case 29:
                    case 31:
                    case 37:
                    case 41:
                    case 43:
                    case 47:
                    case 53:
                    case 59:
                    case 61:
                    case 67:
                    case 71:
                    case 73:
                    case 79:
                    case 83:
                    case 89:
                    case 97:
                    case 101:
                    case 103:
                        yield return new object[] { N, i, true }; break;
                    default:
                        yield return new object[] { N, i, false }; break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }

}
