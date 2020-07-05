// Interface


게임이 성공할 가능성은 코드가 일관성과 안정성을 유지하는 데에 달렸다. 
게임 세계에서 캐릭터와 속성 간의 통일성을 공고히 하고 이런 교류를 주고 받기 위해서 기본 규칙을 몇 개 정해야 한다.
이런 규칙은 interface를 통해 주고 받는 것이 최선이다. 

명명 규칙은 I로 시작한다.

Interfaces are similar to abstract classes in the sense that they can force implementations. 
Abstract classes can be thought of as partial template, and interfaces can be thought of as contract.
Interfaces do not allow for any implementations and can not contain fields. 
You are only able to use methods and properties.	
Interface는 OOP의 중요한 개념인 Polymorphism을 소개한다. 


public interface IDamagable //Interface does not inherit from anything
{
    int Health { get; set; }
    void Damage(int damageAmount); //no implementation details allowed in an interface, whatever implements the interface has to keep up with the signature. 
}

//separate Enemy script
public class Enemy : MonoBehaviour, IDamagable, IShoot
{
    public int Health { get; set; } 
    public void Damage(int damageAmount)
    {
        Health -= damageAmount; 
    }
	
	public void Shoot()
	{
		
	}
}

//separate Playe script
public class Player : MonoBehaviour, IDamagable
{
    public int Health { get; set; }
    public void Damage(int damageAmount)
    {
        
    }
}

Interface also creates what is called multiple inheritance. 
A class can have only one parent class, but it can implement multiple interfaces...
This way you can somehow work around to fake multiple inheritance....

public interface IShoot
{
	void Shoot();
}






Generic Interface

public interface IDamagable<T>
{
	int Health {get; set;}
	// void Damage(int damageAmount);
	// void Damage(float damageAmount); 
	// 위에 것들 대신 generic은 :
	void Damage(T damageAmount);
}

public class Player : MonoBehaviour, IDamagable<int>
{
    public int Health { get; set; }
    public void Damage(int damageAmount)
    {
        
    }
}

public class Enemy : MonoBehaviour, IDamagable<GameObject>, IShoot
{
    public int Health { get; set; } 
    public void Damage(int GameObject)
    {
        
    }
	
	public void Shoot()
	{
		
	}
}









<Abstract Classes and Methods>
Why use abstract class?

Using abstract classes, we can force inheritance. 
I can no longer attach a script that contains an abstract class to an object. 
You can only use the class through inheritance. 

An abstract method can only go into an abstract class.

public abstract class Enemy : MonoBehaviour
{
	public int speed;
	public int health;
	public int gems;
	
	public abstract void Attack(); //notice an abstract method does not come with an implementation {}.
	
	public virtual void Die()
	{
		Destroy(this.gameObject);
	}
}

public class MossGiant : Enemy
{
	public override void Attack() //It must override the inherited Abstract Method. it's a must.
	{
		
	}
	
	public override void Die()
	{
		base.Die();
	}
}




public abstract class Employee : MonoBehaviour
{
    public string companyName;
    public string employeeName;

    public abstract void CalculateMonthlySalary();  
}

public class FullTime : Employee
{
    public int salary;

    public override void CalculateMonthlySalary()
    {

    }
}

public class PartTime : Employee
{
    public int hoursWorked, hourlyRate;

    public override void CalculateMonthlySalary()
    {

    }
}	
