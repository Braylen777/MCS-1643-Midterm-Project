using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleR : MonoBehaviour
{

    public float startSpeed = -5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(1, 1, 1);
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            //Obstacle moves left
            rb.velocity = transform.right * startSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale *= 1.01f;
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