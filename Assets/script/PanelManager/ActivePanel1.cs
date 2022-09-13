using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePanel1 : MonoBehaviour
{

    public GameObject Panel1;
    


   public void OpenPanel()
   {

    if(Panel1 != null){

        Panel1.SetActive(true);
        
    }
   }
}
