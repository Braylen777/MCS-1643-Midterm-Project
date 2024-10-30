using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    public float startSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 1, 1);
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            //Obstacle moves right
            rb.velocity = transform.right * startSpeed;
        }
    }
      //On collision player death  
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Death zone triggered!");
        if (other.gameObject.CompareTag("Player"))
        {
            //destroy the player
            Destroy(other.gameObject);
            GameObject obj = GameObject.Find("Manager");
            obj.GetComponent<Manager>().FrogDeath();
        }
    }
}

