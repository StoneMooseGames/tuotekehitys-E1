using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spider : MonoBehaviour
{
    public float speed;
    public float health;
    private Transform target;
    float deathTimer = 3.0f;
    public GameObject deathParticles;
    public Canvas healthBar;
    RectTransform healthBarLocation;
    public int points;
    Vector2 distanceToPlayer;
    GameObject player;
    Vector2 triggerDistance = new Vector2(6, 3);
    public Animator animator;


    void Start()
    {
        GetComponent<Rigidbody2D>().simulated = true;
        player = GameObject.Find("Player");
        gameObject.tag = "enemy";
        gameObject.name = "Spider";
        deathParticles.SetActive(false);  // start with deathparticle sequence turned off
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //find player
        healthBarLocation = healthBar.GetComponent<RectTransform>(); //store healtbarlocation info
        
    }
    

    void Update()
    {
        if (health <= 0) //if health is below 0
        {
            
            DeathCycle(); //start deathcycle
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            healthBarLocation.position = transform.position; //make healthbar follow enemy
            healthBar.GetComponentInChildren<Slider>().value = health; //adjust slider by current healthvalue
             
        }

        distanceToPlayer = transform.position - player.transform.position;
        //this can be checked to see the distance as a 2d vector
        //Debug.Log(distanceToPlayer);
        //Check distance in x-axis
        if (distanceToPlayer.x < triggerDistance.x)
        {
            GetComponent<Rigidbody2D>().simulated = true;

        }

    }

    public void DeathCycle() 
    {
        
        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3 (180, 0, 0)); // flip object over x-axis by 180 degrees
        if (deathTimer > 0) //while death cycle time is more than 0
        {
            deathTimer -= Time.deltaTime; //make timer go down
            deathParticles.SetActive(true); //start death particle cycle
            healthBar.gameObject.SetActive(false); //remove heawlthbar on death

        }
        else
        {
            Destroy(gameObject); //remove gameobject from game
            GameObject.FindGameObjectWithTag("PlayerUI").GetComponent<PlayerUI>().SetPoints(points); //add points accordingly
        }




        }


}
