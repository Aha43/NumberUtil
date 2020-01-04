Work in progress
# NumberUtil
### Utilities of use when coding with numbers in a readable way using C#
#### Background ####
Coding challenges (for example the [Euler project](https://projecteuler.net/) problems) in C# I started to re-use code over problems and decided to put that stuff in this library.

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


