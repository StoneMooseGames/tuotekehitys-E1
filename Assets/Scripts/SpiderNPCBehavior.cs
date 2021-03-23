using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderNPCBehavior : MonoBehaviour
{
    Vector2 distanceToPlayer;
    GameObject player;
    Vector2 triggerDistance = new Vector2(6, 3);
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //this.gameObject.AddComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().simulated = false;
        player = GameObject.Find("Player");
        gameObject.tag = "enemy";
        gameObject.name = "Spider";
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = transform.position - player.transform.position;
        //this can be checked to see the distance as a 2d vector
        //Debug.Log(distanceToPlayer);
        //Check distance in x-axis
        if (distanceToPlayer.x < triggerDistance.x)
        {
            GetComponent<Rigidbody2D>().simulated = true;

        }
        
    }

    


}
