using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelPassedCounter : MonoBehaviour
{

    public static int levelPassedCounter = 0;
    GameObject level3button;
    GameObject level2button;

    // Start is called before the first frame update
    void Start()
    {
        level2button = GameObject.FindWithTag("btnLevel2");
        level3button = GameObject.FindWithTag("btnLevel3");

        level2button.GetComponent<Button>().interactable  = false;
        level3button.GetComponent<Button>().interactable  = false;


        if(levelPassedCounter == 1){
            level2button.GetComponent<Button>().interactable  = true;
        }

        if(levelPassedCounter == 2){
        level3button.GetComponent<Button>().interactable  = true;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
