using UnityEngine;
using System.Collections;
[RequireComponent (typeof (AudioSource))]

public class Laucher : MonoBehaviour {
	
	
	public Rigidbody ShurikenPrefab;
	public float throwSpeed = 30.0f;
	public AudioClip sound;
	public float cooldown = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Fire1")){

			StartCoroutine("shoot");
		
		}
		
	
	}
	
	IEnumerator shoot(){
		
		
		Rigidbody newShuriken = Instantiate(ShurikenPrefab,transform.position, transform.rotation) as Rigidbody;
			
		newShuriken.transform.Rotate(new Vector3(90,0 ,0));
		
		newShuriken.name = "Shuriken";
		
		newShuriken.velocity = transform.forward * throwSpeed;
		
		Physics.IgnoreCollision(transform.root.GetComponent<Collider>(),newShuriken.GetComponent<Collider>(), true);
		
		GetComponent<AudioSource>().PlayOneShot(sound);
		
		yield return new WaitForSeconds(cooldown);
		
		
		
		
		
	}
}
