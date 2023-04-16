using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerAnimatoin : MonoBehaviour
{
    public GameObject prevAnimation = null;
    public GameObject newAnimation;
    // Start is called before the first frame update
    void Start()
    {
        newAnimation.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        prevAnimation.SetActive(false);
        newAnimation.SetActive(true);
        Debug.Log("Animation should be displayed");
    }

}
