using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisonController : MonoBehaviour
{

    public int eatedFood = 0;
    public int foodToEat = 0;

    GameObject player;
    public GameObject finishLevelPanel;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //finishLevelPanel = GameObject.Find("LivelloCompletato");
        finishLevelPanel.SetActive(false);
       
    }
   

    /**
    * funzione che individua una singola collisione fra due gameobject con due collider
    **/
    void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.tag == "badFood"){

            eatedBadFood();
        }
        
        if(other.gameObject.tag == "goodFood"){
           eatedGoodFood();
        }

        if(other.gameObject.tag == "cibo"){
            eatedGoodFood();
        }

        if(other.gameObject.tag == "traguardo"){
            finishLevel();
        }

    }

    void eatedBadFood(){

        GameObject healthBar = GameObject.FindGameObjectWithTag("healthBar");
        Animator healthBarAnimator =  healthBar.GetComponent<Animator>();
        healthBarAnimator.SetInteger("lifeCounter", healthBarAnimator.GetInteger("lifeCounter") - 1);

        if(healthBarAnimator.GetInteger("lifeCounter") == 0){

            MovePlayer movePlayerScript = player.GetComponent<MovePlayer>(); 
            movePlayerScript.gameOver();
        }
    }

    void eatedGoodFood(){
        
        eatedFood++;
    }

    void finishLevel(){

        if(eatedFood == foodToEat){

//finishLevelPanel = GameObject.FindGameObjectsWithTag("levelFinishPanel")[0];
finishLevelPanel.SetActive(true);
            //finishLevelPanel.SetActive(true);
           
        } else if(eatedFood < foodToEat){
            MovePlayer movePlayerScript = player.GetComponent<MovePlayer>(); 
            movePlayerScript.gameOver();
        }
    }
}
