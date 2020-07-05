//struct is a composite data type
using UnityEngine;
using Systems.Collections;

public struct PlayerData
{
	public Vector3 Pos;
	public int hitPoints;
	public int Ammunition;
	public flaot RunSpeed;
	public float WalkSpeed;
}

PlayerData playerData; //struct라는 data를 사용하기 위해서는 다른 변수 구문과 마찬가지로 변수에 대한 구문을 작성한다.

/*
If you have fewer than four fields to declare in a class and do not need to inherit them, use structs.
Structs handle memory management differently to Classes.
However in C#, memory management is built into the language itself, which is known as garbage collection.

class 와 struct는 여러 측면에서 매우 유사하다. 주목할 만한 차이점은 이들이 사용하는 computer memory와 construct되는 방법이다.
struct 는 value type 인 반면, class는 reference type이다. 차이점이 무엇인가?

Value types are stored on what's called a stack
Reference types are stored on what's called a heap

int, bool, bytes, structs 같은 value type들은 할당된 메모리에 value를 저장한다.
arrays, delegates, class, string 과 같은 reference type들은 할당된 메모리에 value를 저장하는 것이 아닌, value를 가리키는 address를 저장한다.
*/

//struct는 value type이라, 생성자로 생성하지 않더라도 된다.
PlayerData pd = playerData; //pd는 새로운 struct이고, playerData로부터 내용을 복사받는다. 




//본격적으로 class와 struct의 차이점을 살펴본다.
using UnityEngine;
using Systems.Collections;

public class StructVClass : MonoBehaviour
{
	struct MyStruct
	{
		public int a;
	}
	
	class MyClass
	{
		public int a;
	}
	
	void Start()
	{
		MyClass myClass = new MyClass();
		MyStruct mStruct = new MyStruct(); //struct도 생성자를 이용할 수 있나보다...
		
		myClass.a = 1;
		myStruct.a = 1;
		
		MyStruct ms = myStruct;
		ms.a = 3;
		Debug.Log(ms.a + " and " + myStruct.a); //prints 3 and 1
		
		MyClass mc = myClass; //class에 대한 참조만 할당된다*
		mc.a = 3;
		
		MyClass mc2 = new MyClass();
		mc2.a = myClass.a;
		mc2.a = 7;
		
		Debug.Log(mc.a + " and " + myClass.a + " and " + mc2.a); //prints 3, 3, 7
	}
}





using UnityEngine;
using Systems.Collections;

struct BoxParameters //밖에 존재하면 클래스의 capsulization을 깰 수 있다! BoxParameters를 전역적으로 접근 가능한 구조체로 바꾼다.
{
	public float width;
	public float height;
	public float depth;
	public float color;
} //struct 내부에서 field에 값을 할당할 수 없다*

public class Struct : MonoBehaviour
{
    BoxParameters myParameters;
	void Start()
    {
	    myParameters.width = 2;
	    myParameters.height = 3;
	    myParameters.depth = 4;
	    myParameters.color = new Color(1,0,0,1);
    }
	
	void UpdateCube(BoxParameters box)
	{
	    Vector3 size = new Vector3(box.width,box.height,box.depth);
	    gameObject.transform.localScale = size;
	    gameObject.render.material.color = box.color;
	}
	
	void Update()
	{

	}
}
