using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CONTROLER : MonoBehaviour
{
    public Text txt;
    public Text endtxt;
    [SerializeField] public int PlayerPoints = 0;

    [SerializeField] private int ShotsLeft = 20;

    [SerializeField] private GameObject CameraObject;


    [SerializeField] private GameObject ENDSCREENOBJECT;


    void Start()
    {

        txt.text = "Balls Remaining: " + ShotsLeft.ToString() + "\nPoints: " + PlayerPoints.ToString();

    }

    [SerializeField] GameObject SoundQue = null;


    void Update()
    {

        thrower ThrowerObject = CameraObject.GetComponent<thrower>();

        ShotsLeft = ThrowerObject.ShotsRemaining;

        if (!ENDSCREENOBJECT.activeInHierarchy)
        {
            txt.text = "Balls Remaining: " + ShotsLeft.ToString() + "\nPoints: " + PlayerPoints.ToString();

        }



        if (ShotsLeft == 0 && !ENDSCREENOBJECT.activeInHierarchy)
        {

            ENDSCREENOBJECT.SetActive(true);


            endtxt.text = "GAME OVER\nYOU HIT " + PlayerPoints.ToString() + " TARGETS\nTO TRY AGAIN PRESS ESC.";


            Quaternion randomRotation = Random.rotationUniform;

            GameObject projectileInstance = Instantiate<GameObject>(SoundQue, transform.position, randomRotation);


        }

        if (ShotsLeft == 0 )
        {

        }



        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }


    }
}
