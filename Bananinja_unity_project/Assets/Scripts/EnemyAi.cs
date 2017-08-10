using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour {
	
	float distance;
	Transform target; 
	public float lookAtDistance = 15.0f;
	public float attackRange = 0.01f;
	public float moveSpeed = 5.0f;
	public float damping = 6.0f;
	public AnimationClip clipRunAttack;
	public AnimationClip clipIdle;
	public AnimationClip clipRun;
	public AnimationClip clipIdleAttack;
	private bool isItAttacking = false;
	public int DMG = 20;
	
	// Use this for initialization
	void Start () {
		
		if(GameObject.FindGameObjectWithTag("Player") != null){
			
			Debug.Log("Encontrou player");
			target = GameObject.FindGameObjectWithTag("Player").transform;
		}
		GetComponent<Animation>().AddClip(clipRunAttack, clipRunAttack.name);
		GetComponent<Animation>().AddClip(clipIdle, clipIdle.name);
		GetComponent<Animation>().AddClip(clipRun, clipRun.name);
		GetComponent<Animation>().AddClip(clipIdleAttack, clipIdleAttack.name);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	distance = Vector3.Distance(target.position, transform.position);

    if(distance < lookAtDistance && distance > attackRange )
    {
	    isItAttacking = false;
	    follow ();
			
    }   
    if(distance > lookAtDistance)
    {
    
    }
    if(distance < attackRange && isItAttacking == false)
    {
    	StartCoroutine("attack");
    }
		
    if(isItAttacking)
    {
    
			
    }
		
}


	void follow ()
	{
		Quaternion  rotation = Quaternion.LookRotation(target.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
		transform.Translate(Vector3.forward * moveSpeed *Time.deltaTime);
		GetComponent<Animation>().Play(clipRunAttack.name);
	}
	
	IEnumerator attack ()
	{
	    isItAttacking = true;
	    GetComponent<Animation>().Play(clipRunAttack.name);
		target.SendMessage("recieveDMG",DMG);
		
		yield return new WaitForSeconds(2.0f);
		
		isItAttacking = false;
			
	   
	}
	
}