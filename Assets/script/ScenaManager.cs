using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenaManager : MonoBehaviour
{
    public void playGame(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2 );
        SceneManager.LoadScene("scenaLivelli");
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
