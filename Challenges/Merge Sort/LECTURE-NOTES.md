# Code Challenge 26: Merge Sort 


### Recursive Algorithm to Solve a Merge and Sort

#### When solving a Merge and Sort it is best to use a recursive algorithm.  What is a Merge and sort you ask?  Good question.  It is where you take a unsorted array and resort it in order.  So if you are given an array that looks like this: [ 3, 5, 2, 4, 1 ] and make it look like this: [ 1, 2, 3, 4, 5 ].  
#### What is a recusive algorithm you ask?  Well, you're on a roll aren't you. 
![Image 1](Assets/nestingdoll.gif)
#### A recursive algorithm is like a "Russian Nesting Doll".  Each time you activate a method it leads you to repeat that method until you finish then it stacks back in, like a "Russian Nesting Doll" in the above image.

#### Let's take that unsorted array again: [ 3, 5, 2, 4, 1 ].  If we use the following method;

```javascript
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if arr > 1
       DECLARE mid <-- n/2
       DECLARE b <-- arr[0...mid]
        // put the second half in the other array
        DECLARE c <-- arr[mid...n]
        Mergesort(b)
        Mergesort(c)
        Merge(B, c, arr)
```

#### The first line within the method declares the length of the array as n ( ``` DECLARE n <-- arr.length ``` ).  Then we go to the if statement ( ``` if arr > 1 ```).  If the length of the array is greater then 1 execute the code. It divides the array in half, the first half being in a new b array and the second being in a new c array.  Then it does this again and again until the each number in the array is in a seporate array, shrinking each array like a "Russian Nesting Doll.    

##### first run( ``` Mergesort(b) ``` ): b == [ 3, 5 ], c == [ 2, 4, 1 ]
##### then we continue to "Mergesort" b: b == [ 3 ], c == 5
##### with the first half done we now go on to the second half( ``` Mergesort(c) ``` ): b == [ 2 ], c == [ 4, 1 ]
##### Since the 2 is one index long we work on c( ``` Mergesort(c) ``` ): b == [ 4 ], c == [ 1 ]


```javascript
ALGORITHM Merge(b, c, a)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < b && j < c
        if b[i] <= c[j]
            a[k] <-- b[i]
            i <-- i + 1
        else
            a[k] = c[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = b.Length
       add remaining of c to a
    else
       add remaining b to a
       
    return a
```

##### Now each has an array index of 1, it is time to pack the "Russian Nesting Doll" back up( ``` Merge(B, c, arr) ``` ): b == [ 4 ], c == [ 1 ] become a == [ 1, 4 ] when they are merged back together since 1 is less than 4.  
##### This array becomes c again when we pack up the previous method: b == [ 2 ], c == [ 1, 4 ]
##### Since 2 is greater than 1, 1 gets put into the 0 index.  Since 2 is less than 4, 2 gets put into the 1 index and 4 gets put into the 2 index.
##### Now that the second half is all packed up, we work on the first half: b == [ 3 ], c == 5.  Since 3 is less than 5, 3 goes into the 0 index and 5 goes into the 1 index.
##### With one last iteration to close out the 2 halves look like this:  b == [ 3, 5 ], c == [ 1, 2, 4 ].
##### The last interation gets merged through ( ``` Merge(B, c, arr) ``` ).  1 goes into the 0 index since it is less than 3, as well as 2 for the same reason.  3 goes into the 2 index since it is less than 4.  4 goes into the 3 index because it is less than five.  Since array b as a number and c doesn't, 5 is put into the 4 index of array a.
##### Once all the iterations of the "Mergesort" method are closed out array a will look like this: [ 1, 2, 3, 4, 5 ].  It is now completely sorted.