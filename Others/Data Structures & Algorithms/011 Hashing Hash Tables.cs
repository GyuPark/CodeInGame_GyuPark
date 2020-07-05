Hashing 

Hashing is a very common technique for storing data in such a way the data can be inserted and retrieved very quickly.
It uses a data structure called a hash table. 
Hash tables do provide fast insertion, deletion, and retrieval, but operations that involve searching,
such as finding the minimum or maximum value, are not performed very quickly. For these types of operations,
other data structures are preferred(binary search tree).


# Hash table

It is designed around an array. 
The array consists of elements 0 through some predetermined size,
though we can increase the size later if necessary. Each data item is stored in the array based on 
some piece of the data, called the key. To store an element in the hash table, the key is mapped 
into a number in the range of 0 to the hash table size using a function called a hash function. 

The ideal goal of the hash function is to store each key in its own cell in the array.
It is possible for two keys to hash to the same value. This is called a collision and we need
a strategy for dealing with collisions when they occur. 

Determine how large to dimension the array used as the hash table.
1) Array size better be a prime number.




















--------------------
A hash table is a very efficient data structure for storing key-value pairs.
The implementation of a hash table is mostly straightforward, with the tricky part having to do with
choosing a strategy for collisions. 