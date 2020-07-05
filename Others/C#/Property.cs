<Property>







<Property>

It is a smart variable. Not only can you retrieve values from them, but you can also execute functions through them.
What if we wanted to have more control over a variable? For instance, what if we could allow people to access a variable but not allow to set it?


public class Player : MonoBehaviour
{
	private int experience; //a variable
	
	public int Experience //a property
	{
		get
		{
			return experience;
		}
		
		set
		{
			experience = value;
		}
	}
}

public class Game : MonoBehaviour
{
	void Start()
	{
		Player myPlayer = new Player();
		myPlayer.Experience = 5;
		int x = myPlayer.Experience;
	}
}

Two things that you can do with Properties that you cannot do with public variables:
1) Make the field writeonly or readonly
2) Accessors can be treated just like functions



"get" and "set" to define a property
class User
{
     private string name = "helen";
	 public string Name
	 {
	      get 
		  {
		     return name.ToUpper(); 
		  }
		  
		  set 
		  {
		      if (value=="Suresh")
		        name = value; 
		  }
	 }
}


User u = new User();
u.Name = "Rohini"; // set accessor will invoke
Console.WriteLine(u.Name); // get accessor will invoke

만약 get만 있으면 read-only 
set만 있으면 write-only

get set 둘 다 있지만 어떠한 명령도 없을때 auto-implemented - we call it an auto-property.
class User
{
    public string Name {get; set;} //an auto-property
	public string Description {get; private set;} //only this class can set this property.
	public string Info {get; protected set;} //only this class and classes derived from this class can set this Property.
}

A downside to using Property is that it does not show in the inspector.


When to use Properties?
Typically in Manager Classes. 





