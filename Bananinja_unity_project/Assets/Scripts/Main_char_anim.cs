using UnityEngine;
using System.Collections;

public class Main_char_anim : MonoBehaviour {
	
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if((Input.GetAxis("Horizontal"))<0){
		
			if (!GetComponent<Animation>().IsPlaying("LeftS")){
		
				GetComponent<Animation>().Play("Left");
				
				if(Input.GetButton("Fire1")){
		
					GetComponent<Animation>().Play("LeftS");
				}
			}
		
			
		
		}
		else if((Input.GetAxis("Horizontal"))>0){
		
            if(!GetComponent<Animation>().IsPlaying("RightS")){
		
				GetComponent<Animation>().Play("Right");
				
				if(Input.GetButton("Fire1")){
		
					GetComponent<Animation>().Play("RightS");
				}
			}
			
		
		}
		else if((Input.GetAxis("Vertical")>0)){
			
			if (!GetComponent<Animation>().IsPlaying("ForwardS")){
		
				GetComponent<Animation>().Play("Forward");
				
				if(Input.GetButton("Fire1")){
		
					GetComponent<Animation>().Play("ForwardS");
				}
			}
		}
		else if((Input.GetAxis("Vertical"))<0){
		
			if (!GetComponent<Animation>().IsPlaying("BackwardS")){
		
				GetComponent<Animation>().Play("Backward");
				
				if(Input.GetButton("Fire1")){
		
					GetComponent<Animation>().Play("BackwardS");
				}
			}
		
		}
		else
		{
			if (!GetComponent<Animation>().IsPlaying("IdleS")){
		
				GetComponent<Animation>().Play("Idle");
				
				if(Input.GetButton("Fire1")){
		
					GetComponent<Animation>().Play("IdleS");
				}
			}
			
		}
			
			
		
		
	}
	
	
}
