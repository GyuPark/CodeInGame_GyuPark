// 클래스 생성하기

using UnityEngine;
using System.Collections;



class FirstClass
{
	/*데이터 필드는 클래스 내부에 존재하는 정보의 타입을 말한다. 
    access modifier 'public'을 사용해 다른 객체가 데이터 필드를 볼 수 있게 허용해준다. 
	클래스 데이터 필드가 언제 어디에서 선언되는지는 함수가 그 데이터 필드를 보는데 영향을 주지 않는다.
	실제로 클래스 마지막에 와도 된다.
    */ 
	public int num;
	public void PrintNum() 
	{
		Debug.Log(num);
	}
	
	
	/* 클래스 안에 클래스를 작성하면 중첩 클래스가 된다.
       클래스는 여러 이유로 다른 클래스와 소통한다.
	   중첩 클래스라도 public이기만 하면 클래스의 외부에서도 사용할 수 있도록 허용된다. 
    */
	class InsideClass 
	{
		
	}
}


void Start() 
{
	FirstClass firstClass = new FirstClass();
	int firstClass.num = 6;
	
	FirstClass secondClass = new FirstClass();
	int secondClass.num = 11; // 데이터 필드는 클래스의 각 인스턴스에 고유한 instance variable이라고 부른다.
	
	FirstClass.InsideClass insideClass = new FirstClass.InsideClass(); //중첩 클래스 인스턴싱은 이와 같이 한다.
	
	
}

	