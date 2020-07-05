//namespace

using UnityEngine; //외부 library를 써야 아래에 print를 실행시킬 수 있다.

namespace MyNameSpace //namespace 는 class 처럼 선언된다.
{
	public class MyClass //public 을 넣어야 MyClass에 access 할 수 있다.
	{
		public void MyFunction()
		{
			print("hello from MyNameSpace");
		}
	}
}

using UnityEngine; 

namespace MySecondNameSpace
{
	public class MyClass //위와 같은 MyClass다
	{
		public void MyFunction()
		{
			print("hello from MyNameSpace");
		}
	}
}


//새로운 c# script는 다음과 같다.

using UnityEngine;
using System.Collections;
using MyNameSpace; //불러온다
using MySecondNameSpace; //이걸 추가하면 'MyClass' is an ambiguous reference between MyNameSpace and MySecondNameSpace 라는 에러를 발견할 것이다...해결법은 찾아봐라...

public class Example : MonoBehaviour
{
	void Start()
	{
		MyClass mc = new MyClass(); //생성한다
		mc.MyFunction(); //함수를 호출한다
	}
	
	void Update()
	{
		
	}
}

pg411 더보기