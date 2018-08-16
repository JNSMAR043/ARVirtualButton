using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public class rollingBall : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MyDebug(){
        Debug.Log("Debuging");
    }
    public void Fire()
    {
        //transform.position = new Vector3(0, 1.2f, 0);
        var fireVelocity = new Vector3(0, 0, 100);
        var rb = GetComponent<Rigidbody>();
        rb.AddForce(fireVelocity);
        //rigidbody.angularVelocity = Vector3.zero;
    }

    public void Reset()
    {
        var rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 0.125f, 0);
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
