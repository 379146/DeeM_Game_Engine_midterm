using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // [SerializeField] GameObject cloudParticles;

        //[SerializeField] private GameObject throwertime = GameObject.FindWithTag("MainCamera");

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        //Debug.Log($"{gameObject.name} just hit {other.name}.");

        if (other.CompareTag("Ground") || other.CompareTag("Target"))
        {

            //thrower points = throwertime.GetComponent<thrower>();

            //++points.PlayerPoints;

            // Debug.Log($"{gameObject.name} just hit the ground.");
            ContactPoint contact = collision.GetContact(0);
            //Instantiate(cloudParticles, contact.point, cloudParticles.transform.rotation);
            Destroy(gameObject);
        }
    }
}
