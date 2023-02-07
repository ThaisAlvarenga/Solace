using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introConversation : MonoBehaviour
{
    public GameObject targetObject;
    public GameObject myUI;

    void Start()
    {
        targetObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);

        myUI.GetComponent<UIManager>().choice1();

        Debug.Log("You've met rima");
    }
}
