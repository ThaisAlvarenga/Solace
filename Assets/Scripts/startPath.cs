using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPath : MonoBehaviour
{
    public GameObject path;
    public float time = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            path.GetComponent<CPC_CameraPath>().PlayPath(time);
        }
        else if (Input.GetButton("Jump"))
        {
            path.GetComponent<CPC_CameraPath>().PlayPath(time);
        }
        else if(Input.GetButton("xboxB"))
        {
            path.GetComponent<CPC_CameraPath>().StopPath();
        }
        
    }
}