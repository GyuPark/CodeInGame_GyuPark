// 논리와 연산자 logic and operator
// 그리고 Loop 루프

using UnityEngine;
using system.Collections;

//bool 논리는 동작을 켜고 끄는 스위치처럼 생각하는 게 편하다.

public class Example : MonoBehaviour
{
	public bool Bool; //Inspector에 Bool 이라는 체크박스를 노출시킨다.
}

void start()
{
	Bool = (1 == 1);
	Debug.Log(Bool); //prints True
	
	if (Bool)
	{
		Debug.log("Bool is True");
	}
	
	if (!Bool)
	{
		Debug.log("This can only be printed when Bool has value False");
	}
}

//update 함수는 매 프레임마다 실행된다.

public int counter;
public GameObject cube;

void update()
{
	//while 함수 예시
	while(counter<10)
	{
		counter++;
		Debug.Log(counter);
	}
	
	for(initialization; condition; operation) //초기화, 조건, 연산
	{
	}
	
	//for 함수 예시
	//spawns 100 cubes
	for(int = 0; int<100 ; int++)
	{
		float x = Random.range(0,20);
		float y = Random.range(0,20);
		float z = Random.range(0,20);
		
		Instantiate(cube, new Vector3(x,y,z));
	}
	
	
	
	//전위 및 후위 표기법
	
	void Start()
	{
		int i = 0;
		Debug.Log(i);
		while(i<1)
		{
			Debug.Log(i++); //후위 표기법으로, i가 증가하기 전에 각지고 있었던 값을 사용한다. i++가 나타나는 구문 후에 i가 증가한다.
			Debug.Log(i);
		}
	}
	
	void Start()
	{
		int i = 0;
		Debug.Log(i);
		while(++i<1) // 전위 표기법으로, while루프를 실행하는 조건이 거짓으로 시작한다. 
		{
			Debug.Log(i); //도달할 수 없다.
		}
	}
	
	//이와는 반대로
	
	void Start()
	{
		int i = 0;
		Debug.Log(i);
		while(++i<1) //i가 0으로 시작해 루프가 참으로 시작한다.
		{
			Debug.Log(i++); //후위 표기법
			Debug.Log(i);
		}
	}
	
	
}



