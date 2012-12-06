<#
Project Euler - Problem 1

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
#>

function Sum-MultiplesOf3And5($max)
{
    $sum = 0
    for ($i = 1; $i -lt $max; $i++)
    {
        if (($i % 3 -eq 0) -or ($i % 5 -eq 0))
        {
            $sum += $i
        }
    }

    "Sum for $max is $sum"
}


Sum-MultiplesOf3And5 10 #should be 23
Sum-MultiplesOf3And5 1000
