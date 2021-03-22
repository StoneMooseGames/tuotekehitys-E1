using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public float speed;
    public float health;
    private Transform target;
    float deathTimer = 6.0f;
    public GameObject deathParticles;


    void Start()
    {
        deathParticles.SetActive(false);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }


    void Update()
    {
        if (health <= 0)
        {
            DeathCycle();
           
        }
        
        else transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void DeathCycle()
    {
        
        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3 (180, 0, 0));
        if (deathTimer > 0)
        {
            deathTimer -= Time.deltaTime;
            deathParticles.SetActive(true);
        }
        else if(deathTimer < 3)
        {

            Destroy(gameObject);

        }
        


    }


}
