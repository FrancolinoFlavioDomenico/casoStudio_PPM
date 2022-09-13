using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisonController : MonoBehaviour
{

    public int EatedFood = 0;
   

    /**
    * funzione che individua una singola collisione fra due gameobject con du collider
    **/
    void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.tag == "badFood"){

            Debug.Log("you aet a bad food");
            EatedFood++;

           
        }
        
        if(other.gameObject.tag == "goodFood"){

            Debug.Log("you aet a good food");
            EatedFood++;
            
        }

        if(other.gameObject.tag == "cibo"){

            Debug.Log("you aet a good food");
            EatedFood++;
            
        }

    }
}
