//점프구문 return, break, continue

using UnityEngine;
using system.Collections;

/*
break 와 continue keywords 는 객체 목록을 자세히 살펴볼 때 특히 유용하다.
return은 함수를 데이터로 바꿔준다.
*/

public class Example : MonoBehaviour
{
	int func(int a, int b)
	{
		return a+b;
	}
	
	void start()
	{
		int x = func(3,4);
		print(x);
	}
}


void Start()
{
	for (int = 0; i < 100; i++)
	{
		print(i);
		if (i > 10)
		{
			break; //1부터 11까지만 출력되고 끊긴다.
		}
	}
	
	
	for (int = 0; i < 100; i++)
	{
		print(i);
		if (i > 10)
		{
			Debug.Log("i is greater than 10!");
			continue; //루프의 처음으로 돌아가 배열의 다음 항목으로 이동한다. continue는 루프 안에 머물지만 다음 항목으로 건너뛰는 것을 의미한다.
		}
	}
}









//hitpoint 만 가지고 있는 간단한 좀비클라스
//생성하고 나서 제어하고 싶은 객체들이 있다면 array를 생성 후 거기에 집어 넣는다.


//ZombieData.cs
public class ZombieData : MonoBehaviour
{
	public int hitpoints;
}


//Example.cs
public class Example : MonoBehaviour
{
	
	
	void Start()
	{
		public GameObject[] gos = new GameObject[10]; //Zombie data를 저장할 Array 생성
		for (int i = 0; i < 10 ; i++) //zombie 10마리 생성하는 loop
		{
			GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube); //매 회차 primitive cube 생성
			Vector3 v = new Vector3(); //매 회차 cube 위치값을 위한 vector와 xz값 랜덤설정, go의 position에 assign
			v.x = Random.Range(-10,10);
			v.z = Random.Range(-10,10);
			go.transform.position = v;
			go.name = i.ToString(); //go의 이름 할당
			
			if(i%2 == 0) //i가 짝수라면,
			{
				go.AddComponent(typeof(ZombieData)); //ZombieData.cs 스크립트를 component에 추가
			}
			
			gos[i] = go; // 마지막으로 array gos에 go 집어넣기
		}
	}
	
	
	void Update()
	{
		foreach (GameObject go in gos) // 짝수의 이름을 가진 object를 출력하고, 이 객체에 히트포인트 10을 할당한다. 
		{
			ZombieData zd = (ZombieData)go.GetComponent(typeof(ZombieData));
			if (zd == null)
			{
				continue; //the statements between continue and the end of the for body are skipped.
			}
			if (zd.hitpoints > 0)
			{
				break;
			}
			Debug.Log(go.name);
			zd.hitpoints = 10;
		}
	}
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0 ; i < 10; i++)
            {
                if (i == 7) //break once i reaches 7
                {
                    break;
                    Console.WriteLine("You are not supposed to see this");
                }
                if (i == 6)
                {
                    for (int j = 0 ; j < 10; j++) //이중 forloop 실험
                    {
                        if (j == 7) //break once i reaches 7
                        {
                            continue;
                            Console.WriteLine("You are not supposed to see this");
                            
                        }
                        Console.WriteLine("InnerForLoopCount : " +j);
                        
                    }
                }
                Console.WriteLine("start of the iteration" +i);
            }
        }
    }
}

/*
start of the iteration0
start of the iteration1
start of the iteration2
start of the iteration3
start of the iteration4
start of the iteration5
InnerForLoopCount : 0
InnerForLoopCount : 1
InnerForLoopCount : 2
InnerForLoopCount : 3
InnerForLoopCount : 4
InnerForLoopCount : 5
InnerForLoopCount : 6
InnerForLoopCount : 8
InnerForLoopCount : 9
start of the iteration6
*/



