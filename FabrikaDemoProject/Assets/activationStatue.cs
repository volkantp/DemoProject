using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class activationStatue : MonoBehaviour {
    public float force = 10f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        addForceOnce();
    }
    private void addForceOnce()
    {
        rb.AddForce(transform.forward * 10f);
    }
}
