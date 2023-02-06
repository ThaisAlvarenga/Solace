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
    //public CinemachineVirtualCamera camera2;


    // Start is called before the first frame update
    void Start()
    {
        menuCam.gameObject.SetActive(true);
        introCam.gameObject.SetActive(false);
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
}