using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScore : MonoBehaviour
{
    public int fish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Fish") {
            fish += 1;
        }
    }
}
