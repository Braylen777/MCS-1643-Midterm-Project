using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnZoneR : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Truck Moved!");
        if (other.gameObject.CompareTag("Respawn"))
        {
            //Move obstacle back to starting position
            transform.position = new Vector3(18.5f, transform.position.y, transform.position.z);

        }

    }
}

