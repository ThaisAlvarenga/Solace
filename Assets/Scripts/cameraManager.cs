using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraManager : MonoBehaviour
{
    // reference to camera for main menu
    public CinemachineVirtualCamera menuCam;

    // get reference of the cameras and save it in variable
    public CinemachineVirtualCamera introCam;
    public CinemachineVirtualCamera leftCam;
    public CinemachineVirtualCamera rightCam;


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

    public void startGame()
    {
        menuCam.gameObject.SetActive(false);
        introCam.gameObject.SetActive(true);
    }

    public void goLeft()
    {
        leftCam.gameObject.SetActive(true);
    }

    public void goRight()
    {
        rightCam.gameObject.SetActive(true);
    }
}
