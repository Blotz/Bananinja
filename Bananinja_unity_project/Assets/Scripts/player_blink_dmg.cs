using UnityEngine;
using System.Collections;

public class player_blink_dmg : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
     
	
	}
	
	
	void blink(){
		
		StartCoroutine("blinks");
		
	}
	
	IEnumerator blinks(){
		
		
		for(int i= 0; i<5;i++){
			
			yield return new WaitForSeconds(0.05f);
			GetComponent<Renderer>().enabled = false;
			yield return new WaitForSeconds(0.05f);
			GetComponent<Renderer>().enabled = true;
			
		}
		
		
	}
}
