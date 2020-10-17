using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
	public GameObject bench;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiatePrefab", 0f, 1f); 
    }
    void InstantiatePrefab(){
    	Instantiate(bench);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
