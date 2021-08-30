using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IntroController : MonoBehaviour
{
    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Story01");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CreditRoll");
    }
}
