using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook_1 : MonoBehaviour
{

    [SerializeField] float mousesensativityX = 1;
    [SerializeField] float mousesensativityY = 1;

    private void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {

        float deltaMouseX = Input.GetAxis("Mouse X") * mousesensativityX;
        float deltaMouseY = Input.GetAxis("Mouse Y") * mousesensativityY;

        float rotationY = transform.eulerAngles.y + deltaMouseX;
        float rotationX = transform.eulerAngles.x - deltaMouseY;

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.None;

        }

    }
}
