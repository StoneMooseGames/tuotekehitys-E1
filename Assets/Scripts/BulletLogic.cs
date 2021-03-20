using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    float lifeTime = 1.5f;
    void Start(){}
    void Update()
    {
      // FIX: bullets sometimes glitch through the walls
      // this is a temporary solution to destroy glitched bullets
      lifeTime -= Time.deltaTime;
      if ( lifeTime <= 0 ) Destroy( this.gameObject );
    }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check whether spider is hit
        if (collision.gameObject.tag == "spider")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 50, ForceMode2D.Impulse);
            Destroy(this.gameObject);
        }

        //Destroy bullet if it hits any collider
        Destroy(this.gameObject);
    }






}
