using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderNPCBehavior : MonoBehaviour
{
    Vector2 distanceToPlayer;
    GameObject player;
    Vector2 triggerDistance = new Vector2(6, 3);
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.AddComponent<Rigidbody2D>();
        this.GetComponent<Rigidbody2D>().simulated = false;
        player = GameObject.Find("Player");
        this.gameObject.tag = "spider";
    }

    // Update is called once per frame
    void Update()
    {
        distanceToPlayer = this.transform.position - player.transform.position;
        //this can be checked to see the distance as a 2d vector
        //Debug.Log(distanceToPlayer);
        //Check distance in x-axis
        if (distanceToPlayer.x < triggerDistance.x)
        {
            this.GetComponent<Rigidbody2D>().simulated = true;

        }
    }




}
