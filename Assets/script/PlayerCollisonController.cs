using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisonController : MonoBehaviour
{

    int eatedFood = 0;
    public int foodToEat = 0;

    GameObject player;

    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player");
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
            //code for winn
        } else if(eatedFood < foodToEat){
            MovePlayer movePlayerScript = player.GetComponent<MovePlayer>(); 
            movePlayerScript.gameOver();
        }
    }
}
