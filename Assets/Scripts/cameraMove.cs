using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        //rotate the camera con its horizontal
        transform.Rotate(Vector3.up, horizontal * speed * Time.deltaTime);

    }
}
