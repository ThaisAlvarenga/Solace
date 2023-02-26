using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour
{
    public GameObject wall;
    //variable to hold the position of the location we are moving to
    public Transform finalPosition;
    // speed at which wall moves
    public float moveSpeed = 1f;

    bool isMoving = false;

    private void OnTriggerEnter(Collider other)
    {
        // allow the wall to move
        isMoving = true;

        Debug.Log("Wall should start appearing now");

    }

    // Update is called once per frame
    void Update()
    {
        // if the wall is moving
        if (isMoving)
        {
            // move the object towards the final position
            wall.transform.position = Vector3.MoveTowards(wall.transform.position, finalPosition.position, moveSpeed * Time.deltaTime);

            // if the wall reaches its final position
            if(wall.transform.position == finalPosition.position)
            {
                //stop moving
                isMoving = false;
            }
        }
    }
}
