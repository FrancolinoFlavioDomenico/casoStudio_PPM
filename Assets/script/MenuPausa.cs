using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{
    public static bool GiocoInPausa = false;

    public GameObject menuPausaUI;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape)){

            if (GiocoInPausa)
            {
                Riprendi();

            } else
            {
                Pausa();
            }
        }
    }

    void Riprendi()
    {
        menuPausaUI.SetActive(false);
        Time.timeScale=1f;
        GiocoInPausa=false;
    }

    void Pausa()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        GiocoInPausa=true;
    }
}
