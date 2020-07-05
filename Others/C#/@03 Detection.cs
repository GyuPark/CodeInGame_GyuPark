//물체 감지 방법은 네가지

if transform.name.Contains("Enemy") //Name 비교
{
	
}

if (transform.tag == "Enemy") //Tag 비교
{
	
}

if (gameObject.layer ==) //Layer 비교
{
	
}

Enemy enemy = hitInfo.transform.GetComponent<Enemy>(); //Component 유뮤 비교, 가장 사용성이 좋은 방법
if(enemy != null)
{
	enemy.OnDamageProcess();
}



// 테니스 공에 붙은 스크립트
private void OnCollisionEnter(Collision collision)
{
    if (collision.transform.CompareTag("Wall"))
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero; //날아가서 부딪힌 후의 움직임을 없애버림
        transform.position = initialPos; //시작 위치로 소환
    }
}

//ball을 치는 player에 붙은 스크립트
private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Ball"))
    {
        Vector3 direction = aimTarget.position - transform.position; //기하벡터는 new가 필요없나?
		
        //other.gameObject.GetComponent<Rigidbody>().velocity = direction + new Vector3(0, 6, 0);  //0.1,0.2,13
        //other.gameObject.GetComponent<Rigidbody>().velocity = direction * force+ new Vector3(0,5,0); //2배의힘
        other.GetComponent<Rigidbody>().velocity = direction.normalized * force+ new Vector3(0,6,0); //정규화 후 10배의힘

        Vector3 ballDir = transform.position - other.transform.position; 
            if (ballDir.x <= 0)
            {
                animator.Play("forehand");
            }
            else
            {
                animator.Play("backhand");
			}
    }
}