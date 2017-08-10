using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		int DistanceAway = 10; Vector3 PlayerPOS = GameObject.Find("Player").transform.transform.position; GameObject.Find("MainCamera").transform.position = new Vector3(PlayerPOS.x, PlayerPOS.y, PlayerPOS.z - DistanceAway);
	
	}
}
