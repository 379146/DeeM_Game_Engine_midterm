using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class thrower : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    [SerializeField] public int PlayerPoints = 0;

    void Start()
    {

        // GameObject[] junkarray = new GameObject[];
        txt.text = "Balls Remaining: " + (Numberofshots - shotstaken).ToString() + "\nPoints: " + PlayerPoints.ToString();


    }

    [SerializeField] GameObject projectile;
    [SerializeField] private float throwStrength = 20;
    [SerializeField] private float upwardArcInDegrees = 10;
    [SerializeField] private int Numberofshots = 20;
    private int shotstaken = 0;

    //GameObject projectileNEW = null;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && shotstaken < Numberofshots)
        {
            // See the docs, but this generates a random rotation:
            Quaternion randomRotation = Random.rotationUniform;

            // Spawn at the camera's position, but move 0.5m in the camera's forward direction (the way 
            // it is facing). This makes it so that the projectile doesn't spawn inside the camera and
            // end up getting clipped. Remember - the camera has a near and far clipping plane beyond
            // which it can't see things.
            Vector3 spawnPosition = transform.position + transform.forward * 0.5f;

            // Create an instance of the prefab in the world.
            GameObject projectileInstance = Instantiate<GameObject>(projectile, spawnPosition, randomRotation);

            // Get access to the instance's rigidbody.
            Rigidbody rb = projectileInstance.GetComponent<Rigidbody>();

            float upwardArcAngle = Mathf.Deg2Rad * upwardArcInDegrees;
            Vector3 direction = Vector3.RotateTowards(transform.forward, Vector3.up, upwardArcAngle, 0);

            // Apply a force in the camera's forward direction (the direction it is pointing).
            rb.AddForce(direction * throwStrength, ForceMode.Impulse);

            ++shotstaken;
            txt.text = "Balls Remaining: " + (Numberofshots - shotstaken).ToString() + "\nPoints: " + PlayerPoints.ToString();

        }
    }


}
