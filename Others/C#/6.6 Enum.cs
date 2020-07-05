/*
Enums

enumeration의 축약어이다. 
긴 목록을 통한 열거는 단순한 수치 인덱스보다 더 유용한 모든 가능성을 만드는 것을 도울 수 있으며, 그 어떤 특정 패턴을 따를 필요가 없다.
*/

using UnityEngine;
using System.Collections;

public class Enum : Monobehaviour
{
	public enum PrimitiveType //새로운 data type을 만든다고 생각하면 된다.
	{
		Sphere,
		Capsule,
		Cylinder,
		Cube,
		Plane
	}
	//혹은 이러한 형식도 가능하다.
	public enum ColorType{red,blue,brown,orange,white}
	

	public PrimitiveType primitiveType; 
	public ColorType myColor; //myColor는 ColorType의 새로운 instance라고 생각한다. 이 변수를 지정해야 inspector에 drop-down으로 보이게 된다.
	GameObject obj;
	
	void Start()
	{
		obj = GameObject.CreatePrimitive(primitiveType);
		myColor = ColorType.brown;
		int number = (int)myColor; //enum은 실제로 숫자를 기반으로 작동한다.
		Debug.Log(number); //number는 3이다.
	}
	
	void Update()
	{
		// 이미 익숙한 if 구문을 사용할 수도 있지만, 세련되지 못하다. switch 구문을 쓰도록 한다.
		if (myColor == ColorType.red)
		{
			obj.renderer.material.color = Color.red;
		}
		if (myColor == ColorType.blue)
		{
			obj.renderer.material.color = Color.blue;
		}
		if (myColor == ColorType.brown)
		{
			obj.renderer.material.color = Color.brown;
		}
	}
	
}





<Enums>
It allows you to create readable selections based off of integer values.

public class SelectDifficulty : MonoBehaviour
{
	public enum LevelSelector
	{
		Easy, //0 or you can assign it like this : Easy = 1,
		Normal, //1
		Hard, //2
		Expert //3
	}
	
	public LevelSelector currentLevel; //A drop-down should be visible in the inspector
	
	void Start()
	{
		switch(currentLevel)
		{
			case LevelSelector.Easy:
				//blah blah
				break;
			
			case LevelSelector.Normal:
				//blah blah
				break;
        }		
	}
}


You normally use Finite State Machine for Game AI.
We can use Enums to define AI's states and make use of them.

public class EnemyAI : MonoBehaviour
{
	public enum EnemyState
	{
		Patrol,
		Attack,
		Chase,
		Death,
	}
	
	public EnemyState currentState;
	
	void Start()
	{
		currentState = EnemyState.Patrol;
	}
	
	void Update()
	{
		switch (currentState)
		{
			case EnemyState.Patrol:
				Debug.Log("Patrolling");
				break;
			
			case EnemyState.Attack:
				Debug.Log("Attacking");
				break;
				
			case EnemyState.Chase:
				Debug.Log("Chasing");
				break;
				
			case EnemyState.Death:
				Debug.Log("Death");
				break;	
		}
		
		if (Input.GetKeyDown(KeyCode.Space))
		{
			currentState = EnemyState.Attacking;
		}
	}
}


Enums for custom classes

[System.Serializable]
public class Item 
{
	public string name;
	public int ID;
	public Sprite icon;
	
	public enum ItemType
	{
		None,
		Weapon,
		Consumable
	}
	
	public ItemType itemType;
	
	public void Action()
	{
		switch(itemType)
		{
			case ItemType.Weapon:
				Debug.Log("This is a weapon!");
				break;
			
			case ItemType.Consumable:
				Debug.Log("This is a consumable!");
				break;
		}
	}
}


public class ItemDB : MonoBehaviour
{
	public List<Item> itemDB = new List<Item>();
	
	void Start()
	{
		itemDB[0].Action(); //inspector에서 지정한 뒤...
	}
}




Casting Enums to ints

Why? 
Say we use Enums to make a LevelSelector.
A LevelSelector requires that you load the scene by its index. It does not allow you to use Enum values.


using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	public enum Difficulty
	{
		Easy,
		Normal,
		Hard,
		Expert
	}
	
	public Difficulty selectedDifficulty;
	
	void Start()
	{
		SceneManager.LoadScene(selectedDifficulty); //this will give you an error, so instead do this:
		SceneManager.LoadScene((int)selectedDifficulty); //however this does not work with Scenes In Build in Build Settings...
	}
}

