# F# Mutable Variable Swap Bug

This repository demonstrates a common error in F# involving mutable variables and the unexpected behavior when attempting to swap their values.  The issue arises from the fact that mutable variables in F# are passed by reference.

## Bug Description
The `swap` function is intended to swap the values of two mutable integer variables. However, due to pass-by-reference semantics, the function modifies the original variables directly, leading to an incorrect result.

## Solution
The solution involves either using a tuple to return the swapped values or creating a new function that creates copies of the variables before swapping them. This avoids modifying the original variables in place.