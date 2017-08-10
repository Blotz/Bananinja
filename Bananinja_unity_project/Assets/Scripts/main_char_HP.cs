using UnityEngine;
using System.Collections;

public class main_char_HP : MonoBehaviour {
	
	
	public int mainCharHP = 100;
	GameObject render;
	
	// Use this for initialization
	void Start () {
	
		render = GameObject.Find("Box03");
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
		if(mainCharHP <0){
			
			Destroy(this.gameObject);	
		}
	}
	
	
	void recieveDMG(int dmg){
		
		mainCharHP -=	dmg;
		Debug.Log(mainCharHP);
		render.SendMessage("blink");
	}
}
