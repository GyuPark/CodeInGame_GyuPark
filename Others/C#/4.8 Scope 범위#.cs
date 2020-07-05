// 범위 scope

using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour
{
	public int MyInt = 1; //MyInt를 선언한다.
	
	void start()
	{
		Debug.Log(MyInt); //"A local variable MyInt cannot be used before it is declared"라는 에러를 발생시킨다.
		int MyInt = 2;
		Debug.Log(MyInt);
	}
}

/*
첫 번째 출력 함수가 클래스 범위 버전의 MyInt를 출력할 것으로 예상했겠지만 그렇지 않다. 
class 범위 내에 존재하는 MyInt는 함수 내에서 다시 MyInt로 정의하더라도 남아있다.
*/

public class Scope : MonoBehaviour
{
	public int MyInt = 1; //MyInt를 선언한다.
	
	void start()
	{
		Debug.Log(this.MyInt); //class 범위 버전의 MyInt 에 접근하기 위해선 this.를 써야 한다.
		int MyInt = 2;
		Debug.Log(MyInt);
	}
}

this keyword는 본 class에 access
base keyword는 parent class에 access

/*
public 키워드는 클래스 범위 내에서만 사용할 수 있다. 
start() 함수 내에 public int 를 추가하면 에러가 발생한다. 변수를 함수 내부로부터 클래스 범위로 상승시킬 수 없다. 
*/



/*
각 클래스가 유니티 3D에 생성되면 프로젝트 전반에 걸쳐 각 클래스가 모든 다른 클래스를 볼 수 있다.
이는 동일한 이름의 클래스 팡리 두 개는 가질 수 없다는 것을 뜻하기도하며, 동일한 이름을 가진 두 개의 스크립트를 생성하려고 하면 에러가 발생한다는 것을 뜻한다.
*/

//cube라는 gameObject에 첨부된 클라스
public class OtherScope : MonoBehaviour
{
	public float size;
	Vector3 mScale;
	
	void start()
	{
		
	}
	
	void update() 
	{
		mScale = new Vector3(size, size, size);
		gameObject.transform.localScale = mScale;
	}
}

//Main Camera에 첨부된 클라스
public class MoreScope : MonoBehaviour
{
	OtherScope other; //변수를 생성했다. 이것이 가능한 건 클래스 간 접근이 가능하다고 알려주는 것이다. 이를 전역범위라고 한다.
	//class를 instantiate한 게 아니라 그냥 OtherScope에 접근하기 위해 변수를 설정한 것이다. 
	
	void start()
	{
		other = (OtherScope)GameObject.FindObjectOfType(typeof(OtherScope)); //GameObject클래스는 요청하는 타입의 객체를 찾기 위해 씬을 검색하는 FindObjectOfType 함수가 있다.
		Debug.Log(other.gameObject.name);
	}
	
	public float otherScale;
	void update()
	{
		other.size = otherScale; //이 코드를 통해 cuube의 크기가 Main Camera에 할당된 otherScale 변수에 의해 컨트롤 되게 되었다. 
	}
}
	

/*클래스를 언급하지 않고 access할 수 있는 완전 전역적인 변수 설정이 가능한가에 대한 의문이 있을 것이다.
클래스 선언 이전에 변수를 선언하면 어떨까라고 생각하겠지만 불행하게도 이 방법은 동작하지 않는다.
다른 방법이 있다. 나중에 알아본다.
*/

