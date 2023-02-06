using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkIfClicked : MonoBehaviour
{
    public Button button1;
    public Button button2;

    void Start()
    {
        button1.onClick.AddListener(HandleClick);
    }

    void HandleClick()
    {
        hideUI();
        Debug.Log("UI has been removed");
    }

    //hide UI
    public void hideUI()
    {
       
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
    }
}
