using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTracker : MonoBehaviour
{
    void Start()
    {
        TrackerObject = GameObject.FindWithTag("trackertag");
    }

    void Update()
    {
        
    }

    private GameObject TrackerObject;


    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("Ball"))
        {


            CONTROLER ControllerObject = TrackerObject.GetComponent<CONTROLER>();

            ++ControllerObject.PlayerPoints;


            Destroy(gameObject);
        }
    }
}
