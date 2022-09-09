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
    }


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

    void playerJump(){

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
