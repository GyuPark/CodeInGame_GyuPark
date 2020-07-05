/* 지시문 directives 은 클래스와 선택된 라이브러리를 연결해준다.
   아래에 첫 두 지시문으로 시작해야 한다. 지시문은 라이브러리라고 부르는 외부 리소스를 호출한다.
   using 을 치면 다양한 옵션을 drop-down으로 볼 수 있다. 
   추후엔 자신만의 라이브러리를 만들 수 있을 것이다.
*/

using UnityEngine;
using System.Collections;

void start()
{
	//그냥 StreamWriter라고 치면 No Completions Found라는 문구가 보일 것이다.
	System.IO.StreamWriter FirstWriter = new System.IO.StreamWriter(); //using System.IO; 라고 치지 않는다면 specify 해야만 보이는 class도 있다.
	FirstWriter.WriteLine("I'm a new textFile.");
	writer.Flush(); //작업을 끝내라고 이야기 해주어야 한다.
}

/* 이제 MyFile을 explorer에서 찾을 수 있다. 
   게임의 객체나 코드에 모든 텍스트를 작성할 필요는 없다. 
   텍스트 파일을 불러오는 것이 더 좋은 방법이다. 
*/
   



/*   
   다른 Library에 이미 존재하는 특정 이름을 가진 함수를 만들었을 때는 어떻게 해야할까?
   ex)
*/

using UnityEngine;
using System.Collections;
using System;

start()
{
	int Number = Random.Range(0,10); //이 구문은 에러를 불러온다. UnityEngine에 Random과 System의 Random이 충돌하기 때문이다.
	//‘Random is an ambiguous reference between ‘UnityEngine.Random’ and ‘System.Random’ 이라는 에러를 확인 할 수 있다.
	int Number = UnityEngine.Random.Range(0,10); //이와 같이 specify 하면 충돌 에러를 해결할 수 있다.
	
}
	
	
	
