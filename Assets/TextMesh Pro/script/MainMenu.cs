using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void showCredits(){
        SceneManager.LoadScene("scenaCrediti");
    }

    public void exitFromCredits(){
        SceneManager.LoadScene("scenaHome");
    }

    public void quitGame(){
        Application.Quit();
    }

}
