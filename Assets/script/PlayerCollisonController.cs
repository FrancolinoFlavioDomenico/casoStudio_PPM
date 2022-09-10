using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisonController : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.tag == "badFood"){

            Debug.Log("you aet a bad food");
        }
        
        if(other.gameObject.tag == "badFood"){

            Debug.Log("you aet a good food");
        }
    }
}
