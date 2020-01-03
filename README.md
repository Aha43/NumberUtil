Work in progress
# NumberUtil
### Utilities of use when coding with numbers in C# in a readable way
#### Background ####
Coding challenges (for example Euler project problems) in C# I started to re-use code over problems and decided to put that stuff in this library.
#### Prime numbers
##### Test if number is prime number
`101.IsPrime() // return true`
`99.IsPrime() // return false`
##### Prime numbers up to 200 extreacted from a sieve into an array
`var primes = 200.PrimeNumbers().ToArray();`
