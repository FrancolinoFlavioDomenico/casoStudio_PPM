using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    Transform player;
    Vector3 velocity = Vector3.zero;

    [SerializeField]
    float zOffeset = -10f;
    [SerializeField]
    float xOffeset = 10f;
    [SerializeField]
    float yOffeset = 3;

    [SerializeField]
    float smooth = -10f;//"velocita" con cui la camera deve seguire il player


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y + yOffeset, player.position.z + zOffeset);//setto la posizione di default della main camera in modo tale da inquadrare il giocatore
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smooth);//quindi posizione la main camere sul player
    }
}
