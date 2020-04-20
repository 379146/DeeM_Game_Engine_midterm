using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TrackerObject = GameObject.FindWithTag("trackertag");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject TrackerObject;




    // [SerializeField] GameObject cloudParticles;

    //[SerializeField] private GameObject throwertime = GameObject.FindWithTag("MainCamera");

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        //Debug.Log($"{gameObject.name} just hit {other.name}.");

        if (other.CompareTag("Ball"))
        {

            //thrower points = throwertime.GetComponent<thrower>();

            //++points.PlayerPoints;

            // Debug.Log($"{gameObject.name} just hit the ground.");
            //ContactPoint contact = collision.GetContact(0);
            //Instantiate(cloudParticles, contact.point, cloudParticles.transform.rotation);

            CONTROLER ControllerObject = TrackerObject.GetComponent<CONTROLER>();

            ++ControllerObject.PlayerPoints;

            //++TrackerObject.GetComponent<CONTROLER>().PlayerPoints;



            FindObjectOfType<AudioManager>().Play("TARGETHIT");



            Destroy(gameObject);
        }
    }
}
