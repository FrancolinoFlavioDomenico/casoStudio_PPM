using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivePanel2 : MonoBehaviour
{
    public GameObject Panel2;

     public GameObject botton1;
    public GameObject botton3;

   public void OpenPanel2()
   {

    if(Panel2 != null){
        
        Panel2.SetActive(true);
    }

    botton1.SetActive(false);
    botton3.SetActive(false);


   }
}
