using System;
using System.Collections;


/*
The easiest way to define a Collection class in C# is 
to base the class on an abstract class already found in the System.Collections library—the CollectionBase class. 
This class provides a set of abstract methods you can implement to build your own collection. 
The CollectionBase class provides an underlying data structure, 
InnerList (an ArrayList), which you can use as a base for your class.
*/


public class Collection : CollectionBase {
	
	public void Add(Object item) { //Add Method has one parameter - it holds the item to be added to the collection
		InnerList.Add(item);
	}
	
	public void Remove(Object item) { //Remove Method
		InnerList.Remove(item);
	}
	
	public new int Count() {
		return InnerList.Count;
	}
	
	public new void Clear() { //removes all the items from InnerList
		InnerList.Clear();
	}
}
	


					
public class chapter1
{
	public static void Main()
	{
		Collection names = new Collection(); //Instantiate a new class of type "Collection".
		names.Add("David"); //Add the four names as items
		names.Add("Bernica");
		names.Add("Raymond");
		names.Add("Clayton");
        
		foreach (Object name in names)
			Console.WriteLine(name);
		
		Console.WriteLine("Number of names : " + names.Count());
		
		names.Remove("Raymond");
		Console.WriteLine("Number of names : " + names.Count());
		
		names.Clear();
		Console.WriteLine("Number of names : " + names.Count());


	}
}