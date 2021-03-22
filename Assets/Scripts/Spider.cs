using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public float speed;
    public float health;
    private Transform target;


    void Start()
    {

        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }


    void Update()
    {
        if( health <= 0 ) Destroy(gameObject);
        
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
