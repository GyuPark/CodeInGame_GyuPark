Linked Lists

Lists occur naturally in day-to-day life. 
Linked list is one particular type of list, that .NET Framework class library does not contain.

Array is not the perfect data structure. 
Searching for an item in an unordered array is slow because you have to possibly visit every element in the array to find the element you 're searching for.
Ordered arrays are more efficient, but insertions and deletions of elements in them are slow, because you have to shift the elements up or down to make space for insertion or remove space for deletion.

When you determine that the operations performed on an array are too slow for use,
consider using the linked list as an alternative, except if you need random access to the items in the list,
when an array is probably the best choice.

#Linked Lists

A linked list is a collection of class objects called nodes. 
Each node is linked to its successor node in the list using a reference to the successor node.
A node is made up of a field for storing data and the field for the node reference.
The reference to another node is called a link.

A major difference between an array and a linked list is that whereas the elements in an array
are referenced by position(the index), the elements of a linked list are referenced by their relationship
to other elements of the array.

Another thing to notice is that we mark the end of a linked list by pointing to the value null.
Since we are working with class objects in memory, we use the null object to denote the end of the list.
Marking the beginning of a list can be a problem in some cases. It is common in many linked list implementations
to include a special node, called the "header", to denote the beginning of a linked list. 

Insertion becomes a very efficient task when using a linked list. All that is involved is changing
the link of the node previous to the inserted node to point to the inserted node, and setting the link
of the new node to point to the node the previous node pointed to before the insertion.

Removing is just as easy. Simply redirect the link of the node before the deleted node to point to the node
the deleted node points to and set the deleted node's link to null.

There are other methods we can implement in the LinkedList class,
but insertion and deletion are the two methods that define why we use linkedlists over arrays.