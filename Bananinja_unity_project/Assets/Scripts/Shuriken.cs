using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {
	
	
	public float rotationSpeed = 100.0f;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	transform.Rotate(new Vector3(0, 0,rotationSpeed * Time.deltaTime));
	
	}
	
	void OnCollisionEnter(Collision theObject){
	
			Destroy(this.gameObject);
			
	
	}
	
}
