using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	public GameObject monsterPrefab; // Set this in inspector to the monster prefab.
    GameObject monsterInstance;
    Transform[] spawnpoints;  
	
    IEnumerator Start()
    {
        spawnpoints = GetComponentsInChildren<Transform>();
        while (true)
        {
            Spawn();
            while (monsterInstance) // Wait for monster to die.
            {
                yield return null;
            }
            yield return new WaitForSeconds(3); // wait 3 seconds for next monster.
        }
    }

    void Spawn()
    {
         int index = Random.Range(0, spawnpoints.Length - 1);
         var spawnpoint = spawnpoints[index];
         monsterInstance = (GameObject)Instantiate(monsterPrefab, 
                                                   spawnpoint.position,
                                                   spawnpoint.rotation);
	}
	
}
