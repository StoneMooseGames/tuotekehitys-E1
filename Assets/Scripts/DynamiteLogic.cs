using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamiteLogic : MonoBehaviour
{
    public float fuseTime;
    public float explosionRadius;
    AudioSource explosionSound;
    SpriteRenderer spriteRenderer;

    void Start()
    {
      explosionSound = GetComponent<AudioSource>();
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
      fuseTime -= Time.deltaTime;
      if ( fuseTime <= 0 ) Explode();
    }

    void Explode()
    {
      if ( !explosionSound.isPlaying )
      {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll( this.gameObject.transform.position, explosionRadius );
        foreach ( var hitCollider in hitColliders )
        {
          if ( hitCollider.tag == "Destroyable" ) Destroy( hitCollider.gameObject );
          // TODO: player damage
          else if ( hitCollider.name == "Player" ) print( "TODO: oof you took X damage!" );
        }

        explosionSound.Play(); // play audio
        // because Destroy is delayed so that the audio is played correctly,
        // the sprite will be visible too long. Hence we hide the object and destroy it later
        spriteRenderer.enabled = false;
        Destroy( this.gameObject, explosionSound.clip.length );
      }
    }
}
