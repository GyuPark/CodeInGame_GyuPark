// Class Data

/*
메모리의 타입은 heap 과 stack이 있다. stack은 작지만 조직화되어 있다. heap은 더 크고 접근하는 데 오랜 시간이 걸린다.
stack은 값타입이라 class보다 더 빨리 접근할 수 있다. 
struct보다 class가 가지는 주요 장점은 instantiator 추가와 inheritance 이다. 
*/

void DoThings() //스택에 추가되는 int 배열을 만든다
{
	int[] array OfInts = new int[100];
	for (int i =0; i < 100; i++)
	{
		arrayOfInts[i] = i;
	}
}


struct MyStruct
{
	public int a = 0; //structs cannot have instance field initializers error 구조체는 필드에 값을 할당할 수 없다.
	public MyStruct()
	{
	}
}

class MyClass
{
	public int i = 0; 
	public MyClass
	{
	}
}


//const
class Monster
{
	const int MaxHitPoints = 10; //const 키워드는 클래스를 읽는 모두에게 게임을 하는 동안에는 할당된 값이 변경할 수 없다고 알려준다.
}


/*
readonly 선언은 클래스가 선언되거나 초기화 작성되었을 때 변수만 변경할 수 잇도록 해준다. 
아래의 코드는 에러를 발생시킨다. 
A readonly field 'Monster.MaxHitPoints' cannot be assigned to (except in a constructor or a variable initializer)
이 에러는 readonly 변수가 변수, 이니셜라이저, 혹은 생성자에서만 설정되는 것을 의미한다.
*/

public class Monster
{
	public readonly int MaxHitPoints = 10;
	public void SetMaxHP(int hp)
	{
		this.MaxHitPoints = hp;
	}
}

//maxhitpoints를 설정하는 유일한 방법은 다음의 코드를 사용하는 것이다.
public class Monster
{
	public readonly int MaxHitPoints = 10;
	public Monster(int hp) //생성자?
	{
		this.MaxHitPoints = hp;
	}
}


