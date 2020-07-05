Dictionaries

A dictionary is a data structure that stores data as a key-value pair.

The DictionaryBase class is used as an abstract class to implement different data structures
that all store data as key-value pairs. These data structures can be hash tables, linked lists, or
some other data structure type.

One example of a dictionary-based data structure is the SortedList. This class stores key-value pairs
in sorted order based on the key. It is interesting that you can also access the values stored in the
structure by referring to the value's index position in the data structure, which makes the structure
behave somewhat like an array.

A dictionary data structure can be thought of as a computerzied word dictionary.

We can use SortedList when it is important for the keys to be sorted, such as ain a standard word
dictionary, where we expect the words in the dictionary to be sorted alphabetically. 


------------

The DictionaryBase class is an abstract class used to create custom dictionaries.
A dictionary is a data structure that sotres data in key-value pairs, using a hash table(or sometimes a singly linked list)
as the underlying data structure. 