using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class thrower : MonoBehaviour
{
    public Text txt;
    [SerializeField] public int PlayerPoints = 0;

    [SerializeField] GameObject projectile = null;
    [SerializeField] private float throwStrength = 20;
    [SerializeField] private float upwardArcInDegrees = 10;
    [SerializeField] private int Numberofshots = 20;
    private int shotstaken = 0;
    public int ShotsRemaining = 20;


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && shotstaken < Numberofshots)
        {
            Quaternion randomRotation = Random.rotationUniform;

            Vector3 spawnPosition = transform.position + transform.forward * 0.5f;

            GameObject projectileInstance = Instantiate<GameObject>(projectile, spawnPosition, randomRotation);

            Rigidbody rb = projectileInstance.GetComponent<Rigidbody>();

            float upwardArcAngle = Mathf.Deg2Rad * upwardArcInDegrees;
            Vector3 direction = Vector3.RotateTowards(transform.forward, Vector3.up, upwardArcAngle, 0);

            rb.AddForce(direction * throwStrength, ForceMode.Impulse);

            ++shotstaken;
            ShotsRemaining = (Numberofshots - shotstaken);
        }
    }


}
