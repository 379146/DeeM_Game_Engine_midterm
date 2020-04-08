using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {



        //Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        //Vector3 direction = Vector3.RotateTowards(transform.forward, Vector3.zero, 0, 0);

        //rb.AddForce(0, 0, speed, ForceMode.Force);


    }
    private float speed = 0f;
    [SerializeField] double temp = 0;

    // Update is called once per frame
    void Update()
    {

        speed = float.Parse(temp.ToString());

        gameObject.transform.Translate(0, 0, -speed, Space.World);

    }
}
