



<Conditional>
if를 나열하면, 이전 conditional을 만족해 execute 되더라도 다 들쑤신다.
else if와 else 는 앞 conditional 에서 execute 된 것이 있어야 지나친다.





<For Loop>
    public GameObject[] objects;

    private void Start()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].GetComponent<Renderer>().material.color = Color.red;
        }
    }

Use cases:
- Iterater through all monsters in a zone and deal appropriate damage.
- Shatter an object (rigidbody.applyexplosionforce)
- When you add an item to a player inventory
- Turn all game objects in view RED







<While Loop>
Do-While loop이 while과 다른 점은 적어도 한 번은 실행된다는 것 말고는 없다.

If you are going to use an infinite loop, use it through a coroutine. Otherwise, you will crash your program.
    
	int _maxValue;
    int _value;

    private void Start()
    {
        _maxValue = Random.Range(60, 120);
        Debug.Log(_maxValue);
        StartCoroutine(SpeedIncrease());
    }

    IEnumerator SpeedIncrease()
    {
        while (_value < _maxValue) //or you could've made it an infinite loop and add a conditional with a break keyword.
        {
            _value += 5;
            Debug.Log(_value);
            yield return new WaitForSeconds(1.0f);
        }
    }










<Array>

public string[] names = new string[3];
public string[] names; //and add info in the inspector

Array elements 들을 찾아서 넣는 방법
getcomponentsinchildren
findgameobjectswithtag
등등


//Array 배열

//Array comes either as size-fixed or size-adjustable.

using UnityEngine;
using System.Collections;

public class ArraysAFirstLook : MonoBehaviour
{
	public int[] scores = new int[];
	public float[] floats = new float[]; //int와 float는 생성될 때 배열에 디폴트로 0의 값을 가진다
	public string[] strings = new string[]; //반면 strings는 배열 내에 아무것도 없는 상태로 초기화되어 null 또는값이 없는 상태가 된다.
}


public class MyClass
{
}
public MyClass[] MyClasses = new MyClass[10];


/*
Array는 데이터를 다루기에 유용한 도구다.
1. 데이터의 이름을 바꾸어본다.
*/


// 배열을 할당하지 않고 그대로 둘 경우 배열의 크기를 나중에 자유롭게 지정할 수 있다. 혹은 Hierarchy에서 끌어다 드래그앤드롭도 가능하다.
public GameObject[] MyGameObjects; //hierarchy에서 cube 6개를 drag-and-drop 했다고 가정한다.

//데이터를 array에 저장해 이름을 바꾸는 일
void start()
{
	Debug.Log(MyGameObjects.Length);
	for(int i =0; i < MyGameObjects.Length ; i++)
	{
		MyGameObjects[i].name = i.ToString(); //게임 object의 이름을 숫자로 변경한다. array property 'name'과 int method ToString()
	}
	
	foreach(GameObject go in MyGameObjects) //foreach 구문은 배열 내에서 찾을 수 있는 data type에 의존한다.
	{
		Debug.Log(go.name);
	}
}



// 동적 초기화가 뭔지 잘 찾아봐...

public int ArrayLength;
void Start()
{
	float[] DynamicFloats = new float[ArrayLength];
	public int[] Primes = new int[]{1,3,4,5,6,7}; //이것도 가능하다
}

//access array members using while loop
void Start()
{
	int [] scores = new int[10];
	int i = 0;
	while (i < scores.Length)
	{
		Debug.Log(scores[i]); //scores 멤버들은 모두 초기화된 0의 값을 가지고 있다.
		i++;
	}
	
	while (i < scores.Length)
	{
		scores[i] = Random.range(0,100);
		i++;
	}
}






<Lists>
It is similar to array in some aspects, but unlike array it can allow multiple data types and can be extended at runtime.
You would use an array for an inventory system that can hold up to 20 items but a list for an item database, which needs to be extended over a period of time.

	public List<GameObject> enemiesToSpawn = new List<GameObject>(); 
    public GameObject[] objectsToSpawn = new GameObject[10]; //

List 와 Array 의 가장 큰 차이점은 각각 dynamic-size 와 fixed-size라는 것이다.
그 외에 data를 access 하는 방법은 거의 동일하다.

public class GameManager : MonoBehaviour
{
    public List<string> nameList;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nameList.RemoveAt(Random.Range(0, nameList.Count));
            foreach (var name in nameList)
            {
                Debug.Log(name);
            }
        }
    }
}


