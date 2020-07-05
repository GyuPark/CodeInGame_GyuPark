Rotate Object

public class Rotator : MonoBehaviour
{
	void Update()
	{
		transform.Rotate(Vector3.up, Space.Self); //로컬 y축으로 회전
		transform.Rotate(0,1,0, Space.World); //월드 y축으로 회전
	}
}