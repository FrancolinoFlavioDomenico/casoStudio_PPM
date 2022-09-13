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
        
        if (Input.GetKey(KeyCode.Mouse0)){

            if (GiocoInPausa)
            {
                Riprendi();

            } else
            {
                Pausa();
            }
        }
    }

    public void Riprendi()
    {
        menuPausaUI.SetActive(false);
        Time.timeScale=1f;
        GiocoInPausa=false;
    } 

     public void Pausa()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        GiocoInPausa=true;
    }
}
