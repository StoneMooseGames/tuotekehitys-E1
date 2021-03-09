using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamiteLogic : MonoBehaviour
{
    // these will be set in PlayerWeapons when a dynamite object is created
    public float fuseTime;
    public float explosionRadius;

    void Start() {}

    void Update()
    {
      fuseTime -= Time.deltaTime;
      if ( fuseTime <= 0 ) Explode();
    }

    void Explode()
    {
      Collider2D[] hitColliders = Physics2D.OverlapCircleAll( this.gameObject.transform.position, explosionRadius );

      foreach ( var hitCollider in hitColliders )
      {
        if ( hitCollider.name == "wall" ) Destroy( hitCollider.gameObject );

        // TODO: player damage
        else if ( hitCollider.name == "Player" )
          print( "TODO: oof you took X damage!" );
      }

      Destroy( this.gameObject );
    }
}
