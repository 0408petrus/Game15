using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
        Debug.Log("Pindah ke scene" + sceneIndex);
    }

    public void LoadSettings()
    {
        Debug.Log("Pindah ke setting");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Game Quit!");
        Application.Quit(); 
    }
}
