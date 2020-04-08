using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CONTROLER : MonoBehaviour
{
    public Text txt;
    [SerializeField] public int PlayerPoints = 0;

    [SerializeField] private int ShotsLeft = 20;

    [SerializeField] private GameObject CameraObject;



    // Start is called before the first frame update
    void Start()
    {

        txt.text = "Balls Remaining: " + ShotsLeft.ToString() + "\nPoints: " + PlayerPoints.ToString();
        //Debug.Log("GGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGGG");
    }

    // Update is called once per frame
    void Update()
    {

        thrower ThrowerObject = CameraObject.GetComponent<thrower>();

        ShotsLeft = ThrowerObject.ShotsRemaining;


        txt.text = "Balls Remaining: " + ShotsLeft.ToString() + "\nPoints: " + PlayerPoints.ToString();




    }
}
