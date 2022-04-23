using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashSpawn : MonoBehaviour
{	
	public GameObject[] trash;
	[SerializeField] int respawnTime = 5;
	float xMin = 6.5f;
	float xMax = -6.5f;
	float yMin = 4.6f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(trashTime());
    }
	private void spawnTrash(){
		int randTrash = Random.Range(0, 9);
		GameObject trashes = Instantiate(trash[randTrash]) as GameObject;
		trashes.transform.position = new Vector2(Random.Range(xMin, xMax), yMin);
	}

    // Update is called once per frame
    IEnumerator trashTime(){
		while(true){
			yield return new WaitForSeconds(respawnTime);
			spawnTrash();
		}
	}

}

       // int randTrash = Random.Range(0, trash.length);
		
		//Instantiate(trash[randTrash], 

