using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    public GameObject bulletPrefab; // drop bullet prefab here
    Vector3 playerLocation;
    public float bulletSpeed = 15.0f;
    public int dynamites = 6;

    void Start() {}
    void Update() { Controls(); }

    private void Controls()
    {
      if(Input.GetMouseButtonDown(0)) {
        playerLocation = new Vector3(this.transform.position.x, this.transform.position.y,0);
        GameObject bullet = Instantiate(bulletPrefab, playerLocation, Quaternion.identity);
        // -1 == left, 1 == right
        float direction = this.GetComponent<SpriteRenderer>().flipX ? -1 : 1;
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction, 0f);
      }
    }
}
