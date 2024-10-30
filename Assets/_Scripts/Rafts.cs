using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafts : MonoBehaviour
{
    
    public float startSpeed = 5.0f;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            //Obstacle moves right
            rb.velocity = transform.right * startSpeed;
        }
    }
}
