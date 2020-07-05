//함수 method

using UnityEngine;
using System.Collections;

/*Unity3D 개발자들은 C#클래스가 게임 씬의 내부 작업에 직접적으로 접근할 수 있도록 허용해주는 클래스인 MonoBehaviour를 제공한다.
이 클래스는 유니티 3D에 특별히 사용가능한 모든 함수와 데이터 타입의 조합이다. 유니티3D에 클래스를 생성하라고 요청하면 유니티는 자동적으로
void start()와 void update()를 클래스에 추가한다. 이 함수는 진입점(entry point)라고 부른다.
*/

//접근제한자는 반환타입 앞에 위치해야 한다
public int MyFunction()
{
	return 1; // 반환타입을 가지고 있는 함수는 일종의 return 구문을 항상 가지고 있어야 한다.
}

void MySecondFunction()
{
	int i = 0;
	while (i<10)
	{
		print(i);
		i ++;
	}
}
	
	

<Methods>

public GameObject cube;

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        ChangeColour(cube, Color.blue);
    }
}

void ChangeColour(GameObject gameObject, Color colour)
{
    gameObject.GetComponent<Renderer>().material.color = colour;
}
	
<Method Overloading>

The process by which you can give a single method multiple definitions.
what if we wanted to combine numAdd and strAdd?

public class SomeClass
{
    public int Add(int num1, int num2)
	{
	      return num1+num2;
    }
	
	public string Add(string str1, string str2)
	{
	    return str1 + str2;
	}
}

Every method has what is called a signature.
A signature is comprised of a method's name and parameter list.
No two methods can have the same signature within the same scope.
We overload methods by giving a new method the same name but a different signature.


