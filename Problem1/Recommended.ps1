<#
Project Euler - Problem 1

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
#>

function Sum-MultiplesOf3And5($max)
{
    $sum = (Sum-Multiplies $max 3) + (Sum-Multiplies $max 5) - (Sum-Multiplies $max 15)

    "Sum for $max is $sum"
}

function Sum-Multiplies($max, $divisor)
{
    $quotient = [Math]::Floor(($max - 1) / $divisor)
    $divisor * $quotient * ($quotient + 1) / 2
}


Sum-MultiplesOf3And5 10 #should be 23
Sum-MultiplesOf3And5 1000
