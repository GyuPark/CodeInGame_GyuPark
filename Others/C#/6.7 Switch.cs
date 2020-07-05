// Switch

//긴 if-else 구문의 어색함을 덜어줄 수 있게 만들어진 switch 구문, 주요 장점은 속도

int i =  3;
switch(i)
{
	case 1 : print("You got 1"); break; //각각의 case 는 label이라고 부른다.
	case 2 : print("You got 2"); break;
	default : print("Other"); break; //default 는 처리할 수 없는 case가 나타나는 경우 사용가능, 보통 맨 마지막에 넣음.
}

//switch 구문은 enum과 같이 사용될 때 가장 안정적으로 보인다.

public enum MyCases
{
	first,
	second,
	third,
	fourth,
	fifth,
	sixth,
	seventh
}

public MyCases cases;

void Update()
{
	switch(cases) //종종 switch(MyCases)를 인수의 타입으로 잘못 사용하는 경우가 있다. 에러 발생한다.
	{
		case MyCases.first: Debug.Log("FirstCase"); break;
		case MyCases.second : Debug.Log("SecondCase"); break;
		case MyCases.third : Debug.Log("ThirdCase"); break;
		case MyCases.fourth : Debug.Log("FourthCase"); break;
		case MyCases.fifth : Debug.Log("fifthCase"); break;
		case MyCases.sixth : Debug.Log("sixthCase"); break;
		case MyCases.Seventh : Debug.Log("SeventhCase"); break;
	}
}


void Update()
{
	int a = 0;
	switch(a)
	{
		case 0:
		    a = 1;
			FirstFunction(a);
			break;
        case 1:
		    SecondFunction();
            break;
	}
}

void FirstFunction(int i)
{
    switch (i)
	{
		case 0 :
		   Debug.Log("first case");
		   break;
		   
		case 1 :
		   Debug.Log("I was incremented!");
		   break;

	}
}	
		
void SecondFunction()
{
	Debug.Log("second case");
}











// 제어 이동
switch (condition)
{
	case first_condition: //break 구문을 만나기 전까지 코드가 실행된다.
	case second_condition:
	    break;
	case third_condition:
	    break;
}


// goto case : 잊어버리는 게 좋다 나쁜 습관이 든다.
switch (condition)
{
	case first_condition:
	    goto case second_condition;
	case second_condition:
	    break;
	case third_condition:
	    break;
}


//switch 구문은 정수 타입에 국한되어 있다. 아래의 코드는 error를 발생시킨다.
float myFloat = 1f;
switch (myFloat)
{
	case 1.0f:
	   break;
	case 20.0f:
	   break;
}


