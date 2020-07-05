
A collection (stores data and provides operations for) adding, removing, updating the data ~.
It also provides operations for (setting and returning the values of different attributes) of the collection.
It has (a defined set of properties that describe them) and (operations that can be performed on) them. 



Collections

I) Linear Collections
    i) Direct Access : Array, String, Struct
	ii) Sequential Access : Linear List(stacks & queues)
	iii) Generalized indexed : Hash table, Dictionary

II) Non-linear Collections
     
	i) Hierarchical : Tree
	ii) Grouped : Sets, Graphs, Networks
	
	 
	 
Array is a collection of (elements with the same data type) that are (directly accessed) via an integer index.
    - can be static or dynamic
	- not only a built-in data type, but also a class
String is an (immutable) collection of (characters) that can be accessed based on their index, and strings are also implemented as class objects in C#. 
Struct is a (composite data type) that holds data that may consist of many different data types. For instance, an employee record consists of name, age, ID, and etc.


Sequential Access Collections : A list that stores in sequential order

A linear list does (not allow for a direct access) to its element. Elements are (referenced by their position). To access them, 
    i) front -> rare
    ii) (front -> rare) && (rare -> front) at the same time
	
Linear lists are either ordered or unordered. Ordered linear lists have values ordered in respect to each other, e.g. alphabetical order. 
Unordered linear lists are in any order of traversing a list
Order really matters when performing searches!

Some types of linear lists restrict access to their data element.

Stack : Pop & Push operations, "Last-in, First-out"
Queue : Dequeue & Enqueue operations, "First-in, First-out"
    Priority queues, a special type of queue, allows the item in a queue with the highest priority to be removed first.

Hierarchical collections are groups of items divided into levels.
Group collections are nonlinear collection of items that are unordered.