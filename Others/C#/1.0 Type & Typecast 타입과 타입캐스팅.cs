//타입과 타입캐스팅

using UnityEngine;
using System.Collections;



C#의 내장형 타입은 15개가 있다. 
Int, float, double, bool은 일반적으로 value type으로 사용된다. 
이 모든 타입의 공통점은 단일 항목에 저장된다는 것이다. 


우리의 컴퓨터는 메모리에 두 배 혹은 그 보다 더 큰 공간을 할당하지 않는데 이런 타입을 primitive type이라고 한다. 
Int 와 float의 유일한 차이점은 한 번에 사용할 수 있는 비트의 수이다. Int, float, double은 각각 8, 32, 64비트를 사용한다.


String 과 object 타입은 많은 수의 작은 항목을 결합한 것이다. 크기에 따라 다른 메모리를 할당하게 된다. 
여기선 단일 항목만 보지 않기 때문에 이를  reference type 혹은 null type이라고 한다. 
이에 반해 Primitive 과 value type은 동시에 지정 및 할당된다. 


각 타입의 동작을 기억하는 것이 갈수록 중요해질 것이다. 널타입은 아직 수행되지 않은 데이터를 위해 예약된 메모리 내의 공간이다. 
Vector3는 float 변수 세 개의 조합으로써, null type이다. Nullable 타입은 먼저 초기화 되어야 한다. 다음처럼 말이다.

Vector3 v2 = new Vector3(); 



C#은 strong typing 언어다. Strong typing 언어는 타입을 구분해서 사용한다. 
Float 와 double은 소수 다음에 숫자를 가지기 위해 가수라는 비트를 사용하고, 마침표의 위치를 알려주는 비트가 있는데 이를 지수라고 한다. 

Typecasting
i) implicit : 데이터 손실이 없을 때만 가능
ii) explicit : 데이터 손실 가능

Double을 int로 변환하면 가수와 지수를 잃게 된다. 명시적 캐스팅을 사용하는 것은 C# 데이터 손실을 신경 쓰지 않겠다고 알리는 셈이다. 
그렇다고 암시적 캐스팅을 했을 때 데이터 손실이 없다는 의미는 아니다. Int는 double보다 더 중요한 값을 가지고 있을 수도 있다. 

 
 
 
int largeInt = 2147483647;
print(largeInt); //prints 2147483647

float largeFloat = largeInt;
print(largeFloat); //prints 2.147484E+09... 수의 손실이 있다.

int backagain = (int)largeFloat;
print(backagain); //-2147483648 ; 처음의 숫자가 아니다. float를 int로 변환할 때 상당히 중요한 정보 손실이 있었던 것이다.




//6.14 타입 캐스팅 다시보기

프로그래머들이 정수 타입 integral type 이라는 단어를 사용하면 번호가 매겨진다는 의미다. 

using UnityEngine;
using System.Collections;
public class CastingAgain : MonoBehaviour
{
	enum simpleEnum
	{
		a,
		b,
		c
	}
	
	void Start()
	{
		simpleEnum MySimpleEnum = simpleEnum.b;
		int MyInt = MySimpleEnum as int; 
		Debug.Log(MyInt);
	} //error 생기니까 말고
	
	void Start()
	{
		simpleEnum MySimpleEnum = simpleEnum.b;
		int MyInt = (int)MySimpleEnum;
		Debug.Log(MyInt); //1을 얻는다
	} //됨... 모든 명시적 변환이 가능한 건 아니다. 예를 들어 GameObject를 float값으로 변환할 수는 없다.
}



// 6.14.1 (<Type>) vs "as"

우리가 사용할 수 있는 두 가지 방법은 prefix-casting(전위 캐스팅)과 as-casting이다.

// 6.14.2 사용자 정의 타입 변환

class Humanoid
{
	public int hitpoints;
}

class Person : Humanoid
{
	static public implicit operator Zombie 씨발 몰라 안해
}






// 6.20 타입 캐스팅 숫자











































