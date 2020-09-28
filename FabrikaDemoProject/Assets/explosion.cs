using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public Rigidbody rb1;
    public Rigidbody rb2;
    private float forceRandomer = 100f;
    private void Awake()
    {
        forceRandomer = Random.Range(250f,350f);
    }
    
    private void Start()
    {
        rb1.AddForce(forceRandomer,forceRandomer/3,-forceRandomer);
        rb2.AddForce(forceRandomer,forceRandomer/3,forceRandomer);
        rb1.AddTorque(0,forceRandomer/6f,0);
        rb2.AddTorque(0, -forceRandomer/6f, 0);
    }

}
