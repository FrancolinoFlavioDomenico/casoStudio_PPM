using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent (typeof(Rigidbody2D))]//forzo la classa ad aver associato un sprite con rigidbody2d


public class MovePlayer : MonoBehaviour
{
    Rigidbody2D player;
    Animator animation;//varibile per gestire l'animazione del movimento del player

    [SerializeField]//per poter cambiare moveSpeed da unity ispector
    float moveSpeed = 3f;

    //variabili utili per gestire il salto del player
    bool playerCanJump = true;
    bool isJumping = false;
    [SerializeField]//per poter cambiare jumpForce da unity ispector
    float jumpForce = 100000f;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>(); 
    }


    void Update()
    {
        movePlayer();
        playerJump();
        
        if(player.position.y == -10){
            gameOver();
        }
    }

    /**
    * funzione per gestire il movimento di base del player
    **/
    void movePlayer(){

        float h = Input.GetAxis("Horizontal");
        Vector2 velocity = new Vector2(Vector2.right.x * moveSpeed *h, player.velocity.y);

        player.velocity = velocity ;

        if(velocity.x < 0){//se torno indietro
        
            player.transform.localScale = new Vector3(-1, 1, 1);//ribalto il player
        } else{

             player.transform.localScale = new Vector3(1, 1, 1);//ribalto il player 
        }

        animation.SetFloat("isMoving", Mathf.Abs(h));//faccio partire l'animazine della camminata
    }

    /**
    * funzione per gestire il salto del player del player
    **/
    void playerJump(){

        if(playerCanJump){//il player puo saltare

            if(isJumping){//se il player non sta gia effetuando un salto
        
                if(player.velocity.y == 0){//il player è fermo sul terreno

                    isJumping = false;
                    animation.SetBool("isJumping", false);//fermo l'animazione del salto
                }

            } else{

               if(Input.GetAxis("Jump") > 0){

                    player.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);//faccio saltare il player
                    isJumping = true;
                    animation.SetBool("isJumping", true);//faccio partire l'animazione del salto
                }
            }
        }
    }


    /**
    * funzione che individua frame per frame qualunque collisone venga effettuata e e lo segnala all'engine
    **/
    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.tag == "ostacoli non bypassabili")//il player ha toccato il bordo del livello
            playerCanJump = false;
            
       
       if(other.gameObject.tag != "ostacoli non bypassabili")//il player è potenzialmente sul terreno di gioco
            playerCanJump = true;

    }

    void gameOver(){
        Debug.Log("Game over");
    }
}
