//Instancing

using UnityEngine;
using system.Collections;
using system.Collections.Generic;

public class instancing : MonoBehaviour
{
	Vector3 vector = new Vector3();
	
	void update()
	{
		vector.x = Random.Range(0,10);
		vector.y = Random.Range(0,10);
		vector.z = Random.Range(0,10);
		transform.position = vector;
	}
}




/*
공장에서 찍어낸 토스트기는 모두 다른 시리얼 넘버를 가지며, 사용되는 횟수, 위치는 모두 다르다.
한가지 공유하는 정보는 토스터기의 전체 갯수 뿐이다. 

우리가 게임에서 좀비 무리를 만들고자 한다면, 특정 숫자의 좀비를 유지하는 것이 중요하다.
우리는 좀비를 다른 좀비들과 텔레파시를 이용해 연결하는데, 프로그래머는 이를 두고 static 변수 또는 static 함수라고 부른다.

좀비 클래스가 아닌 플레이어 클래스에서 좀비의 숫자를 추적하는 건 어색한 일이다. 좀비에 관련된 데이터는 좀비 클래스에 존재해야 한다.
다른 클래스에 의존하기 시작하면 디버깅할 때 문제가 복잡해진다. 

class가 생성될 때는 하나의 원본 설계도에서 인스턴스된다. 원래 설계도에 static 변수를 넣으면?

static variable : the same variable is shared by all instances of the class that are created, 
and can be private, protected or public.
instance variable : variable is unique to the instance of the class that is created.
*/


//zombie object에 스크립트를 각각 첨부한다.
public class Zombie : MonoBehaviour
{
	int noZombies; //instance variable - instantiate 된 object들 고유의 값들
	static int numZombies; //static variable - 모든 좀비들 간에 공유됨
	
	void start() //클래스가 인스턴스 될 때마다 각 인스턴스(좀비)는 start()함수를 호출한다.
	{
		noZombies++;
		numZombies++;
		Debug.Log(noZombies); //prints 1,1,1,1...
		Debug.Log(numZombies); //prints 1,2,3,4...
	}
}


//다른 예시

public class Zombie : MonoBehaviour
{
	static int numZombies;
	void start()
	{
		numZombies++;
		Debug.Log(numZombies); //prints 1,2,3,4...
	}
	
	public static void CountZombies() //instance 레벨이 아닌 
	{
		Debug.Log(numZombies);
	}
}

public class Player : MonoBehaviour
{
	void Update()
	{
		bool Akey = Input.GetKey(KeyCode.A);
		if(Akey)
		{
			Debug.Log("AKey");
			Zombie.CountZombies();
		}
	}
}







<Static>
Static information is stuck in the program memory for the life of a program.
You do not need to instantiate a class to use its static members.

public class Enemy
{
     public static int enemyCount = 0;
	 
	 public Enemy()
	 {
	     enemyCount++;
	 }
}

public class Game
{
    void Start()
	{
	     Enemy enemy1 = new Enemy();
		 Enemy enemy2 = new Enemy();
		 Enemy enemy3 = new Enemy();
		 
		 int x Enemy.enemyCount; //equals 3
	}
}

An entire class can be static...
public static class Utilities
{
    public static int Add(int num1, int num2)
	{
	    return num1 + num2;
	}
}


or...


public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab);
        }
    }
}

public class EnemyScript : MonoBehaviour //Enemy's component
{
    public static int enemyCount;

    private void OnEnable()
    {
        enemyCount++;
        Destroy(gameObject, 2);
    }

    private void OnDisable()
    {
        enemyCount--;
    }
}

Static methods are unable to communicate with non-static variables.



A typical SDK development project has utility classes.

public static class Utility
{
	//everything in a static class has to be static.
	
	public static void CreateObject()
	{
		//Create a new primitive cube
		GameObject.CreatePrimitive(PrimitiveType.Cube);
	}
	
	public static void ChangePosition()
	{
		//change position of object
	}
}

static 은 무조건 static만 취급한다.

public class Employee
{
	public int ID;
	public string first, last;
	public int salary;
	
	public static string company;
	
	public Employee() //public 생성자
	{
		Debug.Log("Instance Members Initialized.");
	}
	
	static Employee()
	{
		company = "GamveDevHQ"; //static method는 static variable만 건들 수 있음
		Debug.Log("Initilized Static Members");
	}
}


위 클래스를 constructor로 5번 instancing 하면,
static Constructor() 가 가장 먼저 오직 한 번 호출되고,
non-static Constructor() 가 5번 호출된다.
원래 그런 거다.



