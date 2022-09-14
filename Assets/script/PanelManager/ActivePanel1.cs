using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePanel1 : MonoBehaviour
{

    public GameObject Panel1;
    
    public GameObject botton2;
    public GameObject botton3;


   public void OpenPanel()
   {

    if(Panel1 != null){

        Panel1.SetActive(true);
        
    }

    botton2.SetActive(false);
    botton3.SetActive(false);

   }
}
