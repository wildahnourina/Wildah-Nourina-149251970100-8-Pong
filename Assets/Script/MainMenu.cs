using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        Debug.Log("Wildah Nourina Alfiani - 149251970100-8");
        SceneManager.LoadScene("Game");
    }
    public void Author()
    {
        Debug.Log("Wildah Nourina");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
