//ArrayList
https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=netframework-4.8

Static arrays are not very useful when the size of an array is unknown in advance or is likely to 
change during the lifetime of a program. One solution to this problem is to use a type of array that
automatically resizes itself when the array is out of storage space. 

An ArrayList object has a Capacity property that stores its size. The initial value of the property is 16.
The Capacity property can add another 16 elements to the storage space of the ArrayList, 
when its number of elements reaches the limit. 

An ArrayList stores objects using the Object type. If you need a strongly typed array, you should use
a standard array or some other data structure. 

"Strongly typed" is a concept used to refer to a programming
language that (enforces strict restrictions on) (intermixing of values with different data types).


ArrayLists are not used like standard arrays.
Add method vs Insert method

//First, declare it.
ArrayList grades = new ArrayList();

//Add objects to it.
grades.Add(100);

//Though rarely used, the Add method returns an integer indicating the position in the ArrayList where the element was added.
int position;
position = grades.Add(77);
Debug.Log("The grade 77 was added at position : " + position);


The ArrayList has a built-in enumerator that manages iterating through all the objects in the ArrayList, one at a time.

//If you want to add an element to an ArrayList at a particular position, use the Insert method.
grades.Insert(1, 99); //first argument being the insert index, and the second being the element to be inserted.



Properties & Methods to study :

Capacity
Count
Contains()
Remove()
RemoveAt()
IndexOf()
AddRange()
InsertRange()


