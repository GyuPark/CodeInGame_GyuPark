7.8 대리자 함수

delegate 는 data type 처럼 동작한다.
int 와 double이 숫자 타입인 것처럼 delegate는 method 타입이다.

delegate는 변수 내의 함수를 사용하도록 허용해준다.
함수에 변수를 할당할 수 있다면 데이터처럼 사용할 수 있다. 

C#이 가진 능력은 마치 함수가 데이터인 것처럼 변수에 저장하는 것이다.
1. 단, 함수가 저장하는 변수의 시그니처와 위임하려는 함수가 일치하도록 하는 것이다.

class Example : MonoBehaviour 
{
	delegate void MyDelegate(); 
	
	void FirstDelegate()
	{
		Debug.Log("First delegate called");
	}
	void SecondDelegate()
	{
		Debug.Log("Second delegate called");
	}
	
	void Start()
	{
		//대리자를 사용하기 위해 클래스 객체인 것처럼 함수의 instance를 만들어야 한다.
		MyDelegate del = new MyDelegate(FirstDelegate);
		del(); 
		//"First delegate called"가 print 된다.
		del = SecondDelegate; //del은 재할당 된다.
		del();
		//"Second delegate called"가 출력된다.
	}
}



class SecondExample : MonoBehaviour
{
	delegate int MyDelegate(int a, int b);
	
	public int FirstDelegate(int a, int b)
	{
		return a + b;
	}
	public int SecondDelegate(int a, int b)
	{
		return a - b;
	}
	
	void Start()
	{
		MyDelegate del = new MyDelegate(FirstDelegate);
		int add = del(7,3);
		Debug.Log(add);
		
		del = SecondDelegate;
		int sub = del(103,3);
		Debug.Log(sub);
	}
}




class ThirdExample : MonoBehaviour
{
	delegate void MyDelegate(int a);
	
	public MyDelegate del; //변수를 추가하면 다른 객체가 대리자에 접근할 수 있게 해준다.
	
	void FirstDelegate(int a)
	{
		Debug.Log("first delegate :"+a);
	}
	void SecondDelegate(int a)
	{
		Debug.Log("second delegate "+a);
	}
	
	void Start()
	{
		if (del == null)
		{
			del += FirstDelegate;
			del += SecondDelegate;
			del(3);
			//first delegate 과 second delegate 둘다 출력함.
		}
	}
}

이벤트와 이벤트 관리를 배우면 대리자 함수가 어디에 사용되는지 더 확실하게 알 수 있다. 
이벤트는 기본적으로 뭔가 특별한 것이 촉발되면 다른 함수를 호출하는 함수이다. 
일반적으로 충돌 이벤트와 입력 이벤트는 사용자 정의 이벤트를 필요로 한다. 
여기서 대리자가 중요해지는 대목이다.






<Delegates and Events>


public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor); //give delegate a signature
    public ChangeColor onColorChange; //a delegate variable

    public delegate void OnComplete();
    public OnComplete onComplete;

    private void Start()
    {
        onColorChange = UpdateColor; //assign a method of the same signature
        onColorChange(Color.green); //invoke

        //we can add methods to a delegate
        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        //we can remove as well...
        onComplete -= Task3;

        //Best practice is to make sure that it is not null, before invoking it
        if (onComplete != null)
        {
            onComplete();
        }
    }
    

    public void UpdateColor(Color newcolor)
    {
        Debug.Log("BLahBlah");
    }

    public void Task()
    {
        Debug.Log("Task1 Finished");
    }

    public void Task2()
    {
        Debug.Log("Task2 Finished");
    }

    public void Task3()
    {	
        Debug.Log("Task3 Finished");
    }
}


Events are specialized delegates. 
They allow us to create broadcast system for other classes to subscribe or unsubscribe from our delegates.

The cube and the sphere need not know about each other, and yet they can respond simultaneously to an event by subscribing to the Main class.

public class Main : MonoBehaviour
{
    public delegate void ActionClick(); //delegate만으로도 목적을 달성할 수 있지만,
    public static event ActionClick onClick; //event를 사용하는 이유는 다른 클래스에서 직접 invoke할 수는 없지만 subscribe는 허용하기 때문이다.*********

    public void ButtonClick() //버튼함수
   
        if (onClick != null) //checks if the event has any listeners a void event will cause an error.
        {
            onClick();
        }
    }
}

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Main.onClick += TurnRed; //when you subscribe make sure you unsubscribe somewhere in your code, which is usually when the object gets destroyed.
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private void OnDisable()
    {
        Main.onClick -= TurnRed; //unsubscribe
    }
}

public class Sphere : MonoBehaviour
{
    private void Start()
    {
        Main.onClick += Fall;
    }
    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
}



Actions 을 사용하면
delegate 따로 event 따로 할 필요 없이 한 줄로 가능하다.

using System;

    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    public static Action<int> OnDamageReceived;




Function type delegates(return type)

public class Main : MonoBehaviour
{
    //create a program that takes in a string and returns the length of it.
    public delegate int CharacterLength(string text);

    void Start()
    {
        CharacterLength cl = new CharacterLength(GetCharacters);
        Debug.Log(cl("Gyu"));
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}

compare this to :


using System;

public class Main : MonoBehaviour
{
    //create a program that takes in a string and returns the length of it.
    public Func<string, int> CharacterLength;

    void Start()
    {
        CharacterLength = GetCharacters; //their signatures match.
        int count = CharacterLength("Gyu");
    }

    int GetCharacters(string name)
    {
        return name.Length;
    }
}




Lamda expressions allow us to write methods in a line.
compare the code above with : 

public class Main : MonoBehaviour
{
    //create a program that takes in a string and returns the length of it.
    public Func<string, int> CharacterLength;

    void Start()
    {
        CharacterLength = (name) => name.Length; //their signatures match.

        int count = CharacterLength("Jonathan");
    }

}





연습내용
i) Delegate of Type Void with parameters
ii) Delegate of Type Void without parameters
iii) Delegate of Type Return without parameters
iv) Delegate of Type Return with parameters

i)
using System;

public class Main : MonoBehaviour
{
    //create a delegate of type void that calculates the sum of two numbers. 
	//Use a lambda to avoid having a dedicated model

    public static Action<int, int> Sum;

    void Start()
    {
        Sum = (num1, num2) =>
        {
            Debug.Log(num1 + num2);
        };

        Sum(3, 4);
    }
}

ii)
using System;

public class Main : MonoBehaviour
{
    //create a delegate of type void that calculates the has no parametres and returns the gameObjects name

    public static Action objectName;

    void Start()
    {
        objectName =() =>
        {
            Debug.Log(gameObject.name);
        };

        objectName();
    }
}


iii)
using System;

public class Main : MonoBehaviour
{
    //create a delegate of type int that returns the length of the gameObject's name

    public static Func<int> objectName;

    void Start()
    {
        objectName = () => gameObject.name.Length;
        int length = objectName();
        Debug.Log(length);
    }
}


iv)
using System;

public class Main : MonoBehaviour
{
    //create a delegate of type int that takes 2 numbers as a parameter and adds the sum

    public static Func<int, int, int> Sum; //ctrl shift space 눌러서 잘 찾아보기

    private void Start()
    {
        Sum = (num1, num2) => num1 + num2;
        Debug.Log(Sum(2,4));
    }
}

정리하자면
i) void type은 Action 쓰면 되고,
ii) return type은 Func 쓰면 된다.
iii) dedicated function이 필요없거나 어색한 경우 lambda로 하면 빠르고 수월하다.







<callback system>

using System;

public class Main : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MyRoutine(() =>
        {
            Debug.Log("Hi");
        }));
    }

    public IEnumerator MyRoutine(Action onComplete)
    {
        yield return new WaitForSeconds(5.0f);
        onComplete();
        yield return new WaitForSeconds(5.0f);
        onComplete();
    }
}




