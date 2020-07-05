// Move Objects

/*
Unity에서 Object를 이동 또는 회전시킬 때는 두 가지 방법이 있다.
1. Transform Component
2. Physics Engine
*/

using UnityEngine;
using system.Collections;

//using keyboard input
float speed = 3.0f;
void update()
{
	float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");
	
	
	//transform.Translate
	transform.Translate(new Vector3(h, 0, v) * playerSpeed * Time.deltaTime); //or
	
	transform.Translate(Vector3.right * h * playerSpeed * Time.deltaTime);
    transform.Translate(Vector3.forward * v * playerSpeed * Time.deltaTime); //or
	
	Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
	transform.Translate(moveDir.normalized * speed * Time.deltaTime, Space.self);
}
	
	//transform.position
public float i = 2.0f;
void Update()
{
    transform.position = new Vector3(0, i, 0);
	transform.position = Vector3.up * speed * Time.deltaTime;
    this.i -= 0.01f; 
}
	
	
	//or use Unity Physics engine - rigidbody
void update()
{
	GetComponent<Rigidbody>().AddForce(transform.forward * speed); //or
	GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * speed);
	GetComponent<Rigidbody>().velocity = new Vector3(0,0,10); //moves forward 10 units per second
	
}

Translate(Vector(0,0,3)*Time.deltaTime); 은 local좌표로 움직이지만,
AddForce(Vector(0,0,3)*Time.deltaTime); 은 world좌표로 움직일 것이다.

fwd = transform.forward *3;
AddForce(fwd*Time.deltaTime); 를 쓰면  local 좌표로 움직일 것이다.

	