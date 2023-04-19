
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class relaodifPathEnded : MonoBehaviour
{
    public CinemachineDollyCart dollyCart;

    public string sceneName;

    private bool hasReachedEnd = false;

    private void Update()
    {
        if (dollyCart.m_Position == 30.31159f)
        {
            hasReachedEnd = true;
            Debug.Log("DollyCart has reached the end of the path!");
        }

        if (hasReachedEnd)
        {
            StartCoroutine(reloadScene());
        }
    }

    IEnumerator reloadScene()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(sceneName);

    }

    
}
