Advanced Sorting Algorithms

#ShellSort

It is fundamentally an improvement of the insertion sort.
The key concept in this algorithm is that it compares items that are distant rather than adjacent.
As the algorithm loops through the data set, the distance between each item decreases until at the 
end of the algorithm is comparing items that are adjacent.

#MergeSort

A very good example of a recursive algorithm, it works by breaking the data set up into two halves
and recursively sorting each half. When the two halves are sorted, they are brought together using a merge routine.

#HeapSort

Using a data structure called a heap, which is similar to a binary tree but with some important differences.


# Heap

It is similar to a binary tree, but not quite the same. 
1) Usually built using arrays rather than using node references.
2) It must be complete, meaning that each row must be filled in.
3) Each node contains data that is greater than or equal to the data in the child nodes below it.
2 and 3 are very important conditions for a heap.

Heaps are built by inserting nodes into the heap array, whose elements are nodes of the heap.
A new node is always placed at the end of array in an empty array element. 
The problem is that doing this will probably break the heap condition because the new node's 
data value may be greater than some of the nodes above it. To restore the array to the proper heap condition,
we must shift the new node up until it reaches its proper place in the array.
We do this with a method called ShiftUp.



#QuickSort

QuickSort has a reputation, deservedly earned, as the fastest algorithm of the advanced algorithms
we're discussing in this chapter. However, this is only true for large, mostly unsorted data sets.

recursively 계속 반 쪼개는 것. 어떻게 반쪼개는지가 관건.
