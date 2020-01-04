using System;
using System.Collections;
using System.Collections.Generic;

namespace NumberUtil
{
    /// <summary>
    /// Represents all the prime numbers up to and including N using a sieve of Eratosthenes.
    /// </summary>
    public class PrimeNumbers : IEnumerable<long>
    {
        private readonly bool[] _prime;

        /// <summary>
        /// Largest positive natural number this know is prime or not.
        /// </summary>
        public long N { get; private set; }

        /// <summary>
        /// Number of prime numbers in the range 0...N including N.
        /// </summary>
        public long Count { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="n">Largest positive natural number this know is prime or not.</param>
        public PrimeNumbers(long n)
        {
            if (n < 0)
            {
                throw new ArgumentException(nameof(n) + " < 0 : " + n);
            }

            N = n;

            long count = 0;

            _prime = new bool[n + 1];
            if (n > 1)
            {
                for (var i = 2; i < n + 1; i++) _prime[i] = true;
                long lastPrime = 2;
                while (lastPrime != -1)
                {
                    count++;

                    MarkNonPrimes(lastPrime);
                    lastPrime = NextPrime(lastPrime);
                }
            }

            Count = count;
        }

        private long NextPrime(long lastPrime)
        {
            for (long nextPrime = lastPrime + 1; nextPrime < _prime.Length; nextPrime++)
            {
                if (_prime[nextPrime]) return nextPrime;
            }

            return -1;
        }

        private void MarkNonPrimes(long prime)
        {
            for (long i = prime + prime; i < _prime.Length; i += prime)
            {
                _prime[i] = false;
            }
        }

        /// <summary>
        /// Tells if number is prime or not.
        /// </summary>
        /// <param name="n">Number, must not be larger than N</param>
        /// <returns>True if is prime else false</returns>
        public bool IsPrime(long n)
        {
            if (n < 0)
            {
                throw new ArgumentException(nameof(n) + " < 0 : " + n + " < 0");
            }

            if (n < 2) return false;
            
            if (n > N)
            {
                throw new ArgumentException(nameof(n) + " > " + nameof(N) + " : " + n + " > " + N);
            }

            return _prime[n];
        }

        /// <summary>
        /// Iterator that iterates over prime numbers this know.
        /// </summary>
        /// <param name="start">Number to start at, must not larger than N</param>
        /// <returns>Prime numbers</returns>
        //public IEnumerable<long> Primes
        //{
        //    get
        //    {
        //        for (int i = 2; i < N + 1; i++) if (_prime[i]) yield return i;
        //    }
        //}

        // Implementing IEnumerable<long>
        public IEnumerator<long> GetEnumerator()
        {
            for (var i = 2; i < N + 1; i++) if (_prime[i]) yield return i;
        }

        // Implementing IEnumerable<long>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

}
