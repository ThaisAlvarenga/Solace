using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    // get reference of camera and save it in variable
    public CinemachineVirtualCamera camera1;
    public CinemachineVirtualCamera camera2;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            camera1.gameObject.SetActive(true);
            camera2.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            camera1.gameObject.SetActive(false);
            camera2.gameObject.SetActive(true);
        }

    }
}
