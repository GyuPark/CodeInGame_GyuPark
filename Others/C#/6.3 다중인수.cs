// 다중인수 

public int AddTwoNumbers(int a, int b)
{
	return a+b;
}

public int AddDifNumbers(int a, float b)
{
	return a* (int)b;
}

public bool NumbersAreTheSame (int a, int b)
{
	if (a==b)
	{
		return true;
	}
} //에러를 발생시킨다. 모든 코드의 경로가 유효한 부울을 반환하는 것을 기대하고 있다. 반환 값은 항상 채워져 있어야 하고 그렇지 않으면 코드는 컴파일 되지 않는다.

public bool NumbersAreTheSame (int a, int b)
{
	if (a ==b)
	{
		return true;
	}else{
		return false;
	}
}// 반환값이 채워져 있어 컴파일 된다.

