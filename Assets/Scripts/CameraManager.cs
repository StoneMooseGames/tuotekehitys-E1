using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera playerCamera; 
    public Vector3 cameraLocationOffset = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        //at start disable Spriterendering for this, because the sprite is there
        //only to mark the spot for the camera.
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when something enters the collider (Collider is as trigger atm) move camera to the gameobject 
        //where the collider is. TODO if statetents to make sure player is the only one entering the collider
        playerCamera.transform.position = this.gameObject.transform.position; 
    }
}
