using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class DollyController : MonoBehaviour
{
    // the cinemachine dolly cart for this path
    public CinemachineDollyCart dollyCart;
    public CinemachineSmoothPath dollyPath;
    //ui that displays the play and branching buttons
    public GameObject uiCanvas;
    //play ui button
    public Button playButton;
    // new ui button for the branches of the game
    public GameObject newUIButton;


    public float speed = 1.0f;
    public float startDelay = 0.5f;

    // the cinemachine virtual camera
    private CinemachineVirtualCamera virtualCamera;
    //to check if dolly path is active
    private bool isDollyActive;

    private CinemachineBrain cinemachineBrain;


    // Start is called before the first frame update
    void Start()
    {
        //find object with tag XRRig
        GameObject cameraRig = GameObject.Find("XROrigin");

        //get the cinemachine virtual camera from the cameraRig
        virtualCamera = cameraRig.GetComponent<CinemachineVirtualCamera>();

        virtualCamera.Follow = dollyCart.transform;
        virtualCamera.LookAt = dollyCart.transform;
        virtualCamera.Priority = 10;

        cinemachineBrain = FindObjectOfType<CinemachineBrain>();

        //add listener so when play button is clicked, the function StartDollyPath start the path
        playButton.onClick.AddListener(StartDollyPath);

        // do not display the ui element that should be triggered at the end of the path
        newUIButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        /*if (dollyPath.IsValid && virtualCamera != null && virtualCamera.gameObject.activeInHierarchy)
        {
            // Check if the dolly track has reached the end
            if (virtualCamera.State.IsNearEndOfPath && !dollyCart.looped)
            {
                // Deactivate the dolly track
                virtualCamera.gameObject.SetActive(false);

                // Enable the UI elements
                uiCanvas.SetActive(true);

                // Disable the current virtual camera
                virtualCamera.enabled = false;

                // Set the next virtual camera as the current virtual camera
                cinemachineBrain.ActiveVirtualCamera.VirtualCameraGameObject.GetComponent<CinemachineVirtualCameraBase>().enabled = true;
            }
        }*/
        float distanceAlongPath = dollyCart.m_Position + speed * Time.deltaTime;

        // if dolly is active and dolly is not looped and dolly cart position is gr
        if (isDollyActive && dollyCart.m_Path != null && distanceAlongPath < dollyCart.m_Path.PathLength)
        {

            dollyCart.m_Position = distanceAlongPath;

            // Update the position and rotation of the virtual camera
            virtualCamera.transform.position = dollyCart.m_Path.EvaluatePositionAtUnit(distanceAlongPath, dollyCart.m_PositionUnits);
            virtualCamera.transform.rotation = dollyCart.m_Path.EvaluateOrientationAtUnit(distanceAlongPath, dollyCart.m_PositionUnits);

            // Apply the new camera state using the CinemachineBrain component
            CinemachineBrain cinemachineBrain = Camera.main.GetComponent<CinemachineBrain>();
            CameraState cameraState = virtualCamera.State;
            //cinemachineBrain.OverrideCameraState(cameraState);
        }
        else
        {
            // dolly is not longer active
            isDollyActive = false;
            dollyCart.enabled = false;
            newUIButton.SetActive(true);
        }
    }

    //function to start the dolly path 
    void StartDollyPath()
    {
        //hide all the UI elements
        uiCanvas.SetActive(false);

        // set the dolly cart to true
        dollyCart.gameObject.SetActive(true);

        //invoke function to start the dolly path after a delay time;
        Invoke("PlayDollyPath", startDelay);
    }

    //function to play the start
    void PlayDollyPath()
    {
        //enable the virtual camera
        virtualCamera.enabled = true;
        //enable the dolly cart
        dollyCart.enabled = true;

        // dolly is active
        isDollyActive = true;
    }


}
