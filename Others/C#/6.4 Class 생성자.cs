// Class Instantiation

//다음 코드들을 비교해보자 :

//1
class Zombie 
{
	public string name;
	public int hitPoints;
	public int brainsEaten;
}
void Start()
{
	Zombie rob = new Zombie();
	rob.name = "Zombie";
	rob.hitPoints = 10;
	rob.brainsEaten = 0;
}


//2
class Zombie 
{
	public string name;
	public int hitPoints;
	public int brainsEaten;
}
void Start()
{
	Zombie rob = new Zombie(){ //클래스에 매개변수 추가가 가능하다.
		rob.name = "Zombie",
		rob.hitPoints = 10,
		rob.brainsEaten = 0
	};
}


//3
class Zombie
{
	public string Name;
	public int brainsEaten;
	public int hitPoints;
	public Zombie() //이렇게 하지 않아도 Zombie()라는 생성자 함수가 존재할텐데, 충돌은 없는가?
	{
		Name = "Zombie";
		brainsEaten = 0;
		hitPoints = 10;
	}
}


//4
class Zombie
{
	public string Name;
	public int brainsEaten;
	public int hitPoints;
	public Zombie(string n, int hp, int be)
	{
		Name = n;
		brainsEaten = be;
		hitPoints = hp;
	}
}
void Start()
{
	Zombie zombie = new Zombie("Rob",100,0);
}




//훌륭한 예시

class Zombie
{
	public string Name;
	public int Kills;
	public int hitPoints;
	GameObject ZombieMesh;
	public Zombie (string name, int hitpoints) //constructor
	{
		Name = name;
		hitPoints = hitpoints;
		ZombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
		Vector3 pos = new Vector3();
		pos.x = Random.Range(-10,10);
		pos.z = Random.Range(-10,10);
		ZombieMesh.transform.position = pos;
	}
}

void Start()
{
	string[] names = new String[]{"zombie1","zombie2","zombie3"}
	for (int i = 0; i < names.Length; i++)
	{
		Zombie z = new Zombie(names[i], Random.Range(10,15));
	}
}


