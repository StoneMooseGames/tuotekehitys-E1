using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    float lifeTime = 3.0f;
    void Start(){}
    void Update()
    {
      // FIX: bullets sometimes glitch through the walls
      // this is a temporary solution to destroy glitched bullets
      lifeTime -= Time.deltaTime;
      if ( lifeTime <= 0 ) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      // destroy the bullet if it hits a wall
      if( other.name == "Tilemap" ) Destroy(this.gameObject);
    }
}
