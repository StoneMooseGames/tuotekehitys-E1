using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    Vector3 enemyLocation;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        enemyLocation = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y,0);
        Instantiate(enemy, enemyLocation, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
