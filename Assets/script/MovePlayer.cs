using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]//forzo la classa ad aver associato un sprite con rigidbody2d


public class MovePlayer : MonoBehaviour
{
    Rigidbody2D player;

    [SerializeField]//per poter cambiare moveSpeed da unity ispector
    float moveSpeed = 3f;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        movePlayer();
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
    }
}
