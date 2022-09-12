using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Controller : MonoBehaviour
{

    GameObject player;
    List<GameObject> food = new List<GameObject>();
    int foodCounter = 0;

    Collider2D playerCollider;
    List<Collider2D> foodCollider = new List<Collider2D>();

    public int eatedFood = 0;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        player =  GameObject.FindGameObjectWithTag("Player");
        food.AddRange(GameObject.FindGameObjectsWithTag("cibo"));
        foodCounter = food.Count;

        playerCollider = player.GetComponent<Collider2D>();
        
        //int i = 0;
        foreach(GameObject gameObj in food){

            foodCollider.Add(gameObj.GetComponent<Collider2D>());
            //i++;
        }

    }

    // Update is called once per frame
    void Update()
    {    
       // int i = 0;
       // foreach(Collider2D collider in foodCollider){

            //checkCollision();
        //    i++;
        //}

    }

    /**
    * funzione per rilevare la collisione fra il player e il cibo cosi da poter controllare se si è mangiato o meno un cibo
    **/
    void checkCollision(){

        while( i < foodCounter){

            if(foodCollider[i].IsTouching(playerCollider)){

                eatedFood++;
                i++;
                Destroy(food[i]);
            }

            i += 1;
        }


        /*int touchCount = 0;

        if(collider.IsTouching(playerCollider)){

            if(touchCount == 0){

                foodCount++;
                //Destroy(collider.gameObject);
            }
        }*/

    }
}
