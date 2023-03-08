
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadSceneOnTrigger : MonoBehaviour
{
    public string sceneName; // Name of the scene to reload

    private void OnTriggerEnter(Collider other)
    {
        
        SceneManager.LoadScene(sceneName); // Reload the scene
        
    }
}
