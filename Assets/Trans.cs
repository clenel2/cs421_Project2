using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Trans : MonoBehaviour
{
	Animator anim;
    GameObject vBtn;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        vBtn = GameObject.Find("VirtualButton");
        vBtn.GetComponent<VirtualButtonBehaviour>();

    }

    void OnButtonPressed(VirtualButton vb)
    {
        anim.SetTrigger("Active");
    }
    // Update is called once per frame
    void Update()
    {  
        if (Input.GetMouseButtonDown(0)) 
        {
        	anim.SetTrigger("Active");
        }
    }
}
