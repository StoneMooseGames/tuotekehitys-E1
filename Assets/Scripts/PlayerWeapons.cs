﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    public GameObject bulletPrefab; // drop bullet prefab here
    public GameObject dynamitePrefab;
    Vector3 playerLocation;

    public float bulletSpeed = 25.0f;
    // public float fireRate = 1; // TODO
    public int dynamites = 6; // how many the player has

    void Start() {}
    void Update() { Controls(); }

    private void Controls()
    {
      if ( Input.GetMouseButtonDown(0) ) // left click for now
      {
        playerLocation = this.transform.position;
        GameObject bullet = Instantiate(bulletPrefab, playerLocation, Quaternion.identity);
        // -1 == left, 1 == right
        float direction = GetPlayerDirection();
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed * direction, 0f);
      }

      if ( Input.GetMouseButtonDown(1) ) // right click for now
      {
        if ( dynamites > 0 )
        {
          playerLocation = new Vector3(this.transform.position.x + GetPlayerDirection() * 0.5f, this.transform.position.y, 0);
          GameObject dynamite = Instantiate(dynamitePrefab, playerLocation, Quaternion.identity);
          // "send" information to DynamiteLogic script for logic handling

          dynamites--;
        }

        // TODO: if player has no dynamites left,
        // play a sound and / or inform the player elsehow
        else
        {
          print("TODO: you got no dynamites left!");
        }
      }
    }

    float GetPlayerDirection() {
      // -1 == left, 1 == right
      return this.GetComponent<SpriteRenderer>().flipX ? -1 : 1;
    }
}
