﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HONK_TIME : MonoBehaviour
{
    [SerializeField] GameObject SoundQue = null;


    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;


        if (other.CompareTag("Ball"))
        {

            Quaternion randomRotation = Random.rotationUniform;

            GameObject projectileInstance = Instantiate<GameObject>(SoundQue, transform.position, randomRotation);


        }

    }


}
