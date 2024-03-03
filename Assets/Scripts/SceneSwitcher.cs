using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Attributes()
    {
        Application.OpenURL("https://docs.google.com/document/d/1o-yNhTSGo8zpFpb5QmQ2lD_Fyd4_ZWP0OV4t-kHnHQo/edit?usp=sharing");
    }
}
