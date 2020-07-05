// 상속 inheritance

//MonoBehaviour는 DLL에 숨겨진 클래스이다. DLL은 미리 만들어진 코드 세트로 변경되지 않는다.

using UnityEngine; // MonoBehaviour는 UnityEngine으로부터 상속받는다.
using system.Collections;

void start()
{
	myCat Kitty = new myCat(); //to use the class myCat, we must instantiate it.
	Kitty.Meow();
	Debug.Log(Kitty.Paws);
}

public class Cat 
{
	public int Paws = 14;
	public void Meow()
	{
		Debug.Log("meow");
	}
}

public class myCat : Cat
{
	pubilc void executeMethod()
	{
		Meow();
	}
	
}


/*Unity3D로 씬에서 객체를 쉽게 찾을 수 있게 해주는 함수가 매우 많다.
우리가 씬에서 GameObject라는 이름의 객체를 찾는다고 하자.
*/

void start() 
{
	GameObject [] gos = Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
	foreach(GameObject go in gos)
	{
		Debug.Log(go);
	}
}

/*
typeof takes a type name(which you specify at compile time)
GetType gets the runtime type of an instance
is returns true if an instance is in the inheritance tree
*/

class Animal { } 
class Dog : Animal { }

void PrintTypes(Animal a) { 
    Console.WriteLine(a.GetType() == typeof(Animal)); // false 
    Console.WriteLine(a is Animal);                   // true 
    Console.WriteLine(a.GetType() == typeof(Dog));    // true
    Console.WriteLine(a is Dog);                      // true 
}

Dog spot = new Dog(); 
PrintTypes(spot);












//6.13 상속 다시보기

자식 클래스는 부모 클래스에게 함수를 상속받는다. 자식 함수는 부모 함수와 동일한 방법으로 실행된다.
하지만 자식의 함수가 상속된 함수 버전과는 다르게 동작하도록 한다면 어떨까?

함수 선언에서 public 키워드 다음에 놓이는 override 키워드는 자식 함수에게 오래된 동작을 정리하고 새로운 버전을 실행하라고 지시한다.

using UnityEngine;
using System.Collections;
public class Parent : MonoBehaviour
{
	void Start()
	{
		ParentFunction();
	}
	
	public void ParentFunction()
	{
		print("parent says hello");
		FunctionA();
		FunctionB();
	}
	
	public virtual void FunctionA() //함수를 오버라이드 하려면 오버라이드 하려는 함수에 virtual keyword를 추가해야 한다.
	{
		print("function A says hello");
	}
	
	public void FunctionB()
	{
		print("function B says hello");
	}
}

public class Child : Parent
{
	void Start()
	{
		ParentFunction();
	}
	
	public override void FunctionA() //override keyword를 넣어줘야 한다.
	{
		print("I'm a new version of function A");
	}
}






//base keyword

public class Person
{
    protected string ssn = "444-55-6666";
    protected string name = "John L. Malgraine";

    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("SSN: {0}", ssn);
    }
}
class Employee : Person
{
    public string id = "ABC567EFG";
    public override void GetInfo()
    {
        // Calling the base class GetInfo method:
        base.GetInfo();
        Console.WriteLine("Employee ID: {0}", id);
    }
}

class TestClass
{
    static void Main()
    {
        Employee E = new Employee();
        E.GetInfo();
    }
}
/*
Output
Name: John L. Malgraine
SSN: 444-55-6666
Employee ID: ABC567EFG
*/



<Class>

- The name of the constructor is ALWAYS the same as the name of the class.
- Constructors NEVER have a return type, not even void.
- A class can have multiple constructors, but only one of them gets called when an object is initialized.

What do I mean by this? This is a great example of method overloading. 
A constructor with the same name can have different parameters list, hence a different method signature.
	
Let's make an item database that stores items.
It doesn't need to inherit anything from MonoBehaviour.

[System.Serializable] //only through this will we able to show its instances in the inspector.
public class Item //notice that this class doesn't inherit from MonoBehaviour
{
    public string name;
    public int id;
    public string description;

    public Item(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}

public class ItemDatabase : MonoBehaviour
{
    public Item[] items; //you can determine how many elements this array has in the inspector.
}

child class도 [System.Serializable]이 필요하다.

parent class의 method 에 virtual이,
child class의 method 에 override가 있어야 오버라이드 할 수 있다.

A "protected" member is accessible within its class and by derived class instances
"Private" members are accessibly only within the body of the class or the struct in which they are declared.


"sealed"
When applied to a class, the sealed modifier prevents other classes from inheriting from it. 
In the following example, class B inherits from class A, but no class can inherit from class B.

class A {}
sealed Class B : A {}

You can also use the sealed modifier on a method or property that overrides a virtual method or property in a base class.
This enables you to allow classes to derive from your class and prevent them from overriding specific virtual methods or properties.


In the following example, Z inherits from Y but Z cannot override the virtual function F that is declared in X and sealed in Y.

class X
{
    protected virtual void F() { Console.WriteLine("X.F"); }
	protected virtual void F2() {Console.WriteLine("X.F2");}
}

class Y : X
{
    sealed protected override void F() {Console.WriteLine("Y.F");}
	protected override void F2() {Console.WriteLine("Y.F2");}
}

class Z : Y
{
    protected override void F2() { Console.WriteLine("Z.F2");}
}


 