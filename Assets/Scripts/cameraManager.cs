using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraManager : MonoBehaviour
{
    // reference to camera for main menu
    public CinemachineVirtualCamera menuCam;

    // get reference of the cameras and save it in variable
    public GameObject introCam;
    public GameObject leftCam;
    public GameObject rightCam;


    // Start is called before the first frame update
    void Start()
    {
        menuCam.gameObject.SetActive(true);

        // set all cameras that are not needed to inactive
        introCam.gameObject.SetActive(false);
        leftCam.gameObject.SetActive(false);
        rightCam.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* NOTE ---- I can probably just make a script that activate new camera and deactivates previous cam
     * That would make the code more clean and reusable
     */

    public void startGame()
    {
        menuCam.gameObject.SetActive(false);
        introCam.gameObject.SetActive(true);
    }

    // if player goes left
    public void GoLeft() 
    { 
    
        //activate the left camera object
        leftCam.gameObject.SetActive(true);
        //deactivate the intro camera
        introCam.gameObject.SetActive(false);
    }

    //if player goes left 
    public void goRight()
    {
        //activate the right camera
        rightCam.gameObject.SetActive(true);
        introCam.gameObject.SetActive(false);
    }
}

