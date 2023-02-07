using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject title;
    public GameObject playButton;

    public GameObject left;
    public GameObject right;

    public float waitFor = 5f;

    void Start()
    {
        //set all UI elements not needed in the main menu to inactive
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(false);
    }

    public void removeMenuUI()
    {
        // unload the elements of the menu from the scene
        title.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
    }


    //change the UI to the choices
    public void choice1()
    {
        //call co routine that will show the UI
        StartCoroutine(waitAndShowUI());
    }

    IEnumerator waitAndShowUI()
    {
        // wait for 5 seconds
        yield return new WaitForSeconds(waitFor);

        // set UI buttons to active
        left.gameObject.SetActive(true);
        right.gameObject.SetActive(true);

        Debug.Log("new choice UI is active");
    }
}
