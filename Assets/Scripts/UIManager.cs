using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject title;
    public GameObject playButton;

    public void removeMenuUI()
    {
        title.gameObject.SetActive(false);
        playButton.gameObject.SetActive(false);
    }
}
