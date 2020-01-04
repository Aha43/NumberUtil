Work in progress
# NumberUtil
### Utilities of use when coding with numbers in a readable way using C#
#### Background ####
Coding challenges (for example the [Euler project](https://projecteuler.net/)'s problems) in C# I started to re-use code over problems and decided to put that stuff in this library.

#### Working with the digits of numbers
##### Number of digits a number have (int, long and BigInteger)

<!-- T5 -->
```c#
12345.NumberOfDigits(); // Returns 5
(-12345).NumberOfDigits(); // Also returns 5: sign not counted
BigInteger.Multiply(long.MaxValue, 10).NumberOfDigits(); // Returns 20
```
The paranthesises are needed for the negative number or it would mean applying the unary operator - on the result of 12345.NumberOfDigits().
#### Prime numbers
##### Test if number is prime number (int and long)

<!-- T1 -->
```c#
101.IsPrime(); // return true
99.IsPrime(); // return false
```
##### Making a (Eratosthenes) sieve with the prime up to and including N of 211 (211 happens to be a prime)
```c#
var N = 211;
var primeNumbers = new PrimeNumbers(N); // the sieve
````

###### Using the sieve to get number of prime numbers in range [0...N]
<!-- T2 -->
```c#
var numberOfPrimes = primeNumbers.Count; // will be 47 if N = 211
```

###### Using the sieve to test if numbers in the range [0...N] is prime number or not (assumes N = 211)
<!-- T3 -->
```c#
primeNumbers.IsPrime(101); // true
primeNumbers.IsPrime(210); // false
primeNumbers.IsPrime(211); // true
```

###### PrimeNumbers instance is an IEnumerable over primes up to N
<!-- T4 -->
```c#
var largest = primeNumbers.Last(); // using LINQ to get the largest prime less or equal to N.
```

