using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    Transform player;
    Vector3 velocity = Vector3.zero;

    Transform mainCamera;

    [SerializeField]    
    float zOffeset = -10f;  
     [SerializeField]  
    float yOffeset = 1f;
     [SerializeField]  
    float xOffeset = 0f;

    [SerializeField]
    float smooth = -10f;//"velocita" con cui la camera deve seguire il player


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void Update()
    {
        //setto la posizione di default della main camera in modo tale da inquadrare il giocatore
        Vector3 targetPosition = new Vector3(player.position.x + xOffeset, player.position.y + yOffeset, player.position.z + zOffeset);

        //quindi posizione la main camere sul player
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smooth);
    }
}
