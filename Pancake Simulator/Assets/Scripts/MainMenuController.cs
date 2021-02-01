using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    

    public void howTo()
    {
        SceneManager.LoadScene("HowTo");
    }

    public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
