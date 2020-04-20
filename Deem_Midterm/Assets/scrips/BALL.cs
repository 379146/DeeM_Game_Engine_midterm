using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [SerializeField] GameObject SoundQue = null;



    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;


        if (other.CompareTag("Ball"))
        {
        }
        else
        { 
        Quaternion randomRotation = Random.rotationUniform;

        GameObject projectileInstance = Instantiate<GameObject>(SoundQue, transform.position, randomRotation);





    }

    }




}
