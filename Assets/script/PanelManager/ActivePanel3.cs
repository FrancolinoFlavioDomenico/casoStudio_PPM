using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePanel3 : MonoBehaviour
{
    
    public GameObject Panel3;

     public GameObject botton1;
    public GameObject botton2;

   public void OpenPanel3()
   {

    if(Panel3 != null){
        
        Panel3.SetActive(true);
    }

    botton1.SetActive(false);
    botton2.SetActive(false);

   }
}
