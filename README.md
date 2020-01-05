README is work in progress
# NumberUtil
### Utilities of use when coding with numbers in a readable way using C#
#### Background ####
Coding challenges (for example the [Euler project](https://projecteuler.net/)'s problems) in C# I started to re-use code over problems and decided to put that stuff in this library. Guidelines for the design of the library: https://github.com/Aha43/NumberUtil/wiki/NumberUtil-Library-Design-Rules

#### Working with the digits of numbers
##### Number of digits a number have (int, long and BigInteger)
<!-- T5 -->
```c#
12345.NumberOfDigits(); // Returns 5
(-12345).NumberOfDigits(); // Also returns 5: sign not counted
BigInteger.Multiply(long.MaxValue, 1000).NumberOfDigits(); // Returns 22
BigInteger.Multiply(long.MaxValue, -1000).NumberOfDigits(); // Also returns 22
```

The parentheses are needed for the negative number or it would mean applying the unary operator `-` on the result of `12345.NumberOfDigits()`.

##### Getting digits of numbers (int, long and BigInteger numbers >= 0)
<!-- T7 -->
```c#
var dig = 12345.Digits(); // Gets array with digits 1, 2, 3, 4 and 5 (dig[0] = 1 and dig[4] = 5)
```

##### Given digits in base 10 get the number (int, long)
<!-- T8 -->
```c#
var digits = 54321.Digits();
var value = digits.Number(); // value = 54321.
```

#### Prime numbers
##### Test if number is prime number (int and long)
<!-- T1 -->
```c#
101.IsPrime(); // return true
99.IsPrime(); // return false
```

##### Get prime factors of a number (int and long)
<!-- T6 -->
```c#
var factors = 30.PrimeFactors().ToArray(); // Array will contain 2, 3 and 5. 
```
Primes are not iterated over in a sorted order.

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
