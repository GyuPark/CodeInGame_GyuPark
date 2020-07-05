/*
This, as a keyword, is frequently used.
You use it in a function that shares its parameter's name with a variable in its mother class.
*/

using UnityEngine;
using system.Collections;


class MyAwkwardClass
{
	int MyBadlyNamedInt = 0;
	void PoorlyNamedFunction()
	{
		Debug.Log(this.MyBadlyNamedInt); //0출력
		int MyBadlyNamedInt = 7;
		Debug.Log(this.MyBadlyNamedInt); //마찬가지로 0출력
	}
}


class MyClass 
{
	int MyInt = 0;
	void MyFunction (int mi)
	{
		int mInt = mi;
		MyInt = mInt;
		Debug.Log(MyInt); //prints mi 
		Debug.Log(this.MyInt); //prints 0
	} 
}



