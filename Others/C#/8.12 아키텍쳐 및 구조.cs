// 아키텍쳐 및 구조

/*
게임을 위해 구조를 만드는 경우에는 작업 별로 C# 파일을 구분해 놓는 것이 중요하다.
더 많이 구분해놓을 수록 엔지니어들이 모인 팀으로 작업할지라도 파일이 병합되어야 하는 경우가 많이 적어진다.
namespace 의 목적은 게임에 있는 다른 작업의 조직 구조를 생성하는 것이다. 예를 들면 플레이어, 환경, 효과, 괴물, 무기에 대한 네임스페이스 등을 말한다.
각각의 주요 카테고리는 자신만의 namespace를 가지고 있어야 한다. 
*/

//MonoBehaviour라는 클래스가 마음에 들지 않으면, Behavior로 시작하는 방법이 있다.
//회사이름의 네임스페이스로 시작해, Behavior 로 MonoBehaviour를 상속받는 것이다.
using UnityEngine;
using System.Collections;
namespace AGameCo //이 namespace는 많은 구조체를 저장할 수 있는 좋은 장소이다.
{
	public struct GameStats
	{
		public int timesPlayed;
		public int timesDied;
		public int zombiesKilled;
		public float hoursPlayed;
	}
	}
	public class Behavior : MonoBehaviour
	{
	}
}



//이렇게 하면 된다
using UnityEngine;
using System.Collections;
using AGameCo;

public class GameInit : Behavior 
{
	void Start()
	{
	}
	void Update()
	{
	}
}

