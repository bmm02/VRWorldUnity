using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneTransition : MonoBehaviour
{
    // Public variable to specify the scene name in Unity
    public string sceneName;

    // Function to load the specified scene
    public void LoadScene()
    {
        // Check if sceneName has been set
        if (!string.IsNullOrEmpty("NEWENVIRONMENTBOTHLIGHTANDDARK"))
        {
            SceneManager.LoadScene("NEWENVIRONMENTBOTHLIGHTANDDARK");
        }
        else
        {
            Debug.LogWarning("Scene name is not set in the Inspector!");
        }
    }
}
