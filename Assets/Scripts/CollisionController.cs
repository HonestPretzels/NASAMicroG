﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate(Collider collision)
    {
        Rigidbody r = collision.gameObject.GetComponent<Rigidbody>();
        r.AddForce(0.35f * OVRInput.GetLocalControllerAcceleration(OVRInput.Controller.RTouch));
    }
}
