using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class b_roll : MonoBehaviour, IVirtualButtonEventHandler {
    public GameObject BtnObj;
    public Animator cubeAni;
    // Use this for initialization
	void Start () {
        BtnObj = GameObject.Find("Button");
        BtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //cubeAni.GetComponent<Animator>();		
	}
    public void OnButtonPressed(VirtualButtonBehaviour vb){
        //start rolling

        //cubeAni.Play("animation");
        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb){
        //cubeAni.Play("none");
        Debug.Log("Release");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
