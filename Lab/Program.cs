using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var shortL = CreateShortNumberArrayDecl();
            var uShortL = CreateUShortNumberArrayDecl();
            var intL = CreateIntNumberArrayDecl();
            var uIntL = CreateUIntNumberArrayDecl();
            var longL = CreateLongNumberArrayDecl();
            var uLongL = CreateULongNumberArrayDecl();

            Console.WriteLine();
            Console.WriteLine(shortL);
            Console.WriteLine(uShortL);
            Console.WriteLine(intL);
            Console.WriteLine(uIntL);
            Console.WriteLine(longL);
            Console.WriteLine(uLongL);
        }

        private static string CreateShortNumberArrayDecl()
        {
            var numbers = new List<ulong>();

            short f = 1;
            for (short i = 0; i < 101 && f > 0; i++)
            {
                f = FactorialShort(i);
                if (f != 0) numbers.Add((ulong)f);
                Console.WriteLine(i.ToString() + " : " + f.ToString());
            }

            return CreateNumberArrayDecl("short", numbers);
        }

        private static string CreateUShortNumberArrayDecl()
        {
            var numbers = new List<ulong>();

            ushort f = 1;
            for (ushort i = 0; i < 101 && f > 0; i++)
            {
                f = FactorialUShort(i);
                if (f != 0) numbers.Add((ulong)f);
                Console.WriteLine(i.ToString() + " : " + f.ToString());
            }

            return CreateNumberArrayDecl("ushort", numbers);
        }

        private static string CreateIntNumberArrayDecl()
        {
            var numbers = new List<ulong>();

            int f = 1;
            for (int i = 0; i < 101 && f > 0; i++)
            {
                f = FactorialInt(i);
                if (f != 0) numbers.Add((ulong)f);
                Console.WriteLine(i.ToString() + " : " + f.ToString());
            }

            return CreateNumberArrayDecl("int", numbers);
        }

        private static string CreateUIntNumberArrayDecl()
        {
            var numbers = new List<ulong>();

            uint f = 1;
            for (uint i = 0; i < 101 && f > 0; i++)
            {
                f = FactorialUInt(i);
                if (f != 0) numbers.Add((ulong)f);
                Console.WriteLine(i.ToString() + " : " + f.ToString());
            }

            return CreateNumberArrayDecl("uint", numbers);
        }

        private static string CreateLongNumberArrayDecl()
        {
            var numbers = new List<ulong>();

            long f = 1;
            for (long i = 0; i < 101 && f > 0; i++)
            {
                f = FactorialLong(i);
                if (f != 0) numbers.Add((ulong)f);
                Console.WriteLine(i.ToString() + " : " + f.ToString());
            }

            return CreateNumberArrayDecl("long", numbers);
        }

        private static string CreateULongNumberArrayDecl()
        {
            var numbers = new List<ulong>();

            ulong f = 1;
            for (ulong i = 0; i < 101 && f > 0; i++)
            {
                f = FactorialULong(i);
                if (f != 0) numbers.Add(f);
                Console.WriteLine(i.ToString() + " : " + f.ToString());
            }

            return CreateNumberArrayDecl("ulong", numbers);
        }

        private static string CreateNumberArrayDecl(string type, List<ulong> numbers)
        {
            var sb = new StringBuilder();

            var n = numbers.Count;
            sb.Append("\t\tprivate static readonly ").Append(type).Append("[] _").Append(type).Append("Factorials = new ").Append(type).Append("[]").Append(" { ");
            for (int i = 0; i < n; i++)
            {
                if (i > 0) sb.Append(", ");
                sb.Append(numbers[i]);
            }
            sb.AppendLine(" };");

            return sb.ToString();
        }

        private static ushort FactorialUShort(ushort n)
        {
            checked
            {
                try
                {
                    if (n == 0) return 1;
                    var retVal = n;
                    for (ushort f = (ushort)(n - 1); f > 0; f--)
                    {
                        retVal *= f;
                    }

                    return retVal;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                    return 0;
                }
            };
        }

        private static short FactorialShort(short n)
        {
            checked
            {
                try
                {
                    if (n == 0) return 1;
                    var retVal = n;
                    for (short f = (short)(n - 1); f > 0; f--)
                    {
                        retVal *= f;
                    }

                    return retVal;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                    return 0;
                }
            };
        }

        private static int FactorialInt(int n)
        {
            checked
            {
                try
                {
                    if (n == 0) return 1;
                    var retVal = n;
                    for (int f = n - 1; f > 0; f--)
                    {
                        retVal *= f;
                    }

                    return retVal;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                    return 0;
                }
            };
        }

        private static uint FactorialUInt(uint n)
        {
            checked
            {
                try
                {
                    if (n == 0) return 1;
                    var retVal = n;
                    for (uint f = n - 1; f > 0; f--)
                    {
                        retVal *= f;
                    }

                    return retVal;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                    return 0;
                }
            };
        }

        private static long FactorialLong(long n)
        {
            checked
            {
                try
                {
                    if (n == 0) return 1;
                    var retVal = n;
                    for (long f = n - 1; f > 0; f--)
                    {
                        retVal *= f;
                    }

                    return retVal;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                    return 0;
                }
            };
        }

        private static ulong FactorialULong(ulong n)
        {
            checked
            {
                try
                {
                    if (n == 0) return 1;
                    var retVal = n;
                    for (ulong f = n - 1; f > 0; f--)
                    {
                        retVal *= f;
                    }

                    return retVal;
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.ToString());
                    return 0;
                }
            };
        }

    }

}
