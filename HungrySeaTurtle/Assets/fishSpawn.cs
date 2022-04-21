using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishSpawn : MonoBehaviour
{
	[SerializeField] GameObject fishPrefab;
	[SerializeField] float respawnTime = 1.0f;
	float xMin = 8.0f;
	float yMin = 4.6f;
	float yMax = -4.3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fishTime());
    }
	private void spawnFish(){
		GameObject fishes = Instantiate(fishPrefab) as GameObject;
		fishes.transform.position = new Vector2( xMin, Random.Range(yMin, yMax));
	}

    // Update is called once per frame
    IEnumerator fishTime(){
		while(true){
			yield return new WaitForSeconds(respawnTime);
			spawnFish();
		}
	}

}
