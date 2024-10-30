using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
   
// Update is called once per frame
    public class Player : MonoBehaviour
    {
        public GameObject PlayerPrefab;
        public KeyCode up;
        public KeyCode left;
        public KeyCode right;
        public KeyCode space;
        public float playerSpeed = 2.0f;

        
    

        void Update()
        {
        if (Input.GetKey(up))
        {
            transform.position += Vector3.forward * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(left))
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(right))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            if (Pscore == 1)
            {
                PlayerPrefab.GetComponent<Renderer>().material.color = new Color(255/255, 213/255, 0/255);
                transform.Rotate(Time.deltaTime * playerSpeed, 35, 0, Space.Self);
                transform.gameObject.tag = "FrogShield";
            
            }
        }
        {
            if (Pscore > 1) 
            {
                PlayerPrefab.GetComponent<Renderer>().material.color = new Color(42/255, 255/255, 44/255);
                transform.Rotate(0, 0, 0, Space.Self);
                transform.gameObject.tag = "Player";
            }
        }    
    }
    
    //public GameObject GoalPrefab;
    private int Pscore;
    public int FrogWin = 3;

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Death zone triggered!");
        if (other.gameObject.CompareTag("Goal"))
        {
            Debug.Log(Pscore);
            Destroy(other.gameObject);
            Pscore++;
            //GoalPrefab.GetComponent<Renderer>().enabled = false;
            gameObject.transform.position = new UnityEngine.Vector3(0, 0.5f, -23f);
        }
        {
            if (Pscore >= FrogWin)
            {

                GameObject obj = GameObject.Find("Manager");
                obj.GetComponent<Manager>().WinScreen();
            }

        }
        
        {

        }
    }
}   

