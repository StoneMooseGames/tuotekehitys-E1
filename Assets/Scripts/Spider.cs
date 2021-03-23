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


    void Start()
    {
        deathParticles.SetActive(false);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        healthBarLocation = healthBar.GetComponent<RectTransform>();
    }


    void Update()
    {
        if (health <= 0)
        {
            DeathCycle();
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            healthBarLocation.position = transform.position;
            healthBar.GetComponentInChildren<Slider>().value = health;
             
        }

    }

    public void DeathCycle()
    {
        
        this.gameObject.transform.rotation = Quaternion.Euler(new Vector3 (180, 0, 0));
        if (deathTimer > 0)
        {
            deathTimer -= Time.deltaTime;
            deathParticles.SetActive(true);
            healthBar.gameObject.SetActive(false);
        }
        else Destroy(gameObject);

       


    }


}
