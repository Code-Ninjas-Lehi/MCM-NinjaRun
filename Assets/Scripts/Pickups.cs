﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public ParticleSystem Pickup;
    public GameObject door;
    void Start()
    {
       Pickup.Stop();
    }

    void Update()
    {
    
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            Destroy(door);

            Pickup.Play();
        }
}
}
