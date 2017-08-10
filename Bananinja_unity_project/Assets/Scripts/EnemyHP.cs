using UnityEngine;
using System.Collections;

public class EnemyHP : MonoBehaviour {
	
	
	
	public int enemyHP = 1000;
	public int shurikenDMG = 40;
	public AudioClip sound;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(enemyHP < 0){
			
			Destroy(this.gameObject);
			
		}
		
		
	}
	
	void OnCollisionEnter(Collision theObject){
	
			if(theObject.gameObject.tag == "Shuriken"){
				
				enemyHP -= shurikenDMG;
				Debug.Log(enemyHP);
				GetComponent<AudioSource>().PlayOneShot(sound);
			}
	
		}
}
