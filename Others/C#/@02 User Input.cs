// Input

using UnityEngine;
using system.Collections;


bool hitting;
void update()
{
	//takes horizontal and vertical input values that are continuous within -1 ; 1
	h = Input.GetAxis("Horizontal");
	v = Input.GetAxis("Vertical");
	
	//assign key press boolean value
	if (Input.GetKeyDown(Keycode.F)
	{
		hitting = true;
		Debug.Log(hitting);
	}
	else if (Input.GetKeyUp(Keycode.F)
	{
		hitting = false;
		Debug.Log(hitting);
	}
	
	if (Input.GetMouseButtonDown(0))
        {
            GameObject clones = Instantiate(bullet, pos.position, pos.rotation); //중요!
            Destroy(clones, 1.0f);
        }
	
	
	
	//creative use of boolean key press
	if ((h != 0 || v != 0) && hitting)
	{
		
	}
	else if ((h !=0 || v !=0) && !hitting)
	{
		
	}
	
	
	void Update() //rotate camera with mouse slide
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");

        Vector3 dir = new Vector3(-y, x, 0);
        Vector3 angle = transform.eulerAngles;

        angle += dir * rotSpeed * Time.deltaTime;
        angle.y = Mathf.Clamp(angle.y, -90, 90);

        transform.eulerAngles = angle;
        
    }