/*
One of the problems with OOP is a feature called “code bloat.” One type of
code bloat occurs when you have to override a method, or a set of methods,
to take into account all of the possible data types of the method’s parameters.
One solution to code bloat is the ability of one value to take on multiple data
types, while only providing one definition of that value. This technique is
called generic programming.
*/




using System;
using System.Collections;

public class chapter1 {
	public static void Main() { //let's test Swap function!
		
		int num1 = 100;
		int num2 = 200;
		Console.WriteLine("num1: "+num1);
		Console.WriteLine("num2: "+num2);
		
		Swap<int>(ref num1, ref num2);
		Console.WriteLine("num1: "+num1);
		Console.WriteLine("num2: "+num2);
		
		string str1 = "Sam";
		string str2 = "Tom";
		Console.WriteLine("String 1:"+ str1);
        Console.WriteLine("String 2:"+ str2);

		Swap<string>(ref str1, ref str2);
        Console.WriteLine("String 1:"+ str1);
        Console.WriteLine("String 2:"+ str2);
	}
	
	
	/* 
    A generic program provides a data type “placeholder” that is filled in by a specific data type at compile-time.
    This placeholder is represented by a pair of angle brackets (< >), with an identifier placed between the brackets.
	It is placed immediately after the function name. The identifier placed inside the angle brackets is now used whenever a
    generic data type is needed. Each of the parameters is assigned a generic data type, as is the temp variable used to make the swap.
    */
	static void Swap<T>(ref T val1, ref T val2) { //Swap function is a canonical example for generic programming.
		T temp;
		temp = val1;
		val1 = val2;
		val2 = temp;
	}
}


/*
Generics are not limited to function definitions; you can also create generic
classes. A generic class definition will contain a generic type placeholder after
the class name. Anytime the class name is referenced in the definition, the type
placeholder must be provided.
*/

//page 16 for detailed explanations
public class Node<T> {
	T data;
	Node<T> link;
	public Node(T data, Node<T> link) {
		this.data = data;
		this.link = link;
	}
}

// This class can be used as follows :
Node<string> node1 = new Node<string>("Mike", null);
Node<string> node2 = new Node<string>("Raymond", node1);
					
