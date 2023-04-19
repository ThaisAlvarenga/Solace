
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;


public class reloadSceneOnTrigger : MonoBehaviour
{
    public string sceneName; // Name of the scene to reload
    public CinemachineDollyCart dollyCart;

    void Update()
    {
        if(dollyCart.m_Position > 30f)
        {
            SceneManager.LoadScene(sceneName); // Reload the scene
        }
       
        
    }
}
