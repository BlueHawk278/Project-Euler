# Problem 001 — Multiples of 3 or 5

## Problem

[View Problem 001 on Project Euler](https://projecteuler.net/problem=1)

## Initial Thoughts

The problem is asking for the sum of all the multiples of 3 or 5 below 1000. 

A number is a multiple of another number if it can be divided by it with no remainder.
This can be checked using the modulo (%) operator.

## Approach

Iterate through every integer from 0 up to 999. For each number, check if it is divisible by 3 or 5.

If it is divisible by either 3 or 5, add it to a running total.

Use || (logical OR) rather than two seperate conditions so that numbers that are multipls of both 3 and 5 are only counted once.

## Implementation

The solution is implemented in C# using a for loop and the modulo operator.

## Result

Answer: 233168

## Reflection

The main concept to understand in this problem is the use of the module operator to test divisibility.