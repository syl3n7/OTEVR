using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() => SceneManager.LoadScene("Terreno2");
    public void Back() => SceneManager.LoadScene("Main");
    public void QuitGame() => Application.Quit();
}
