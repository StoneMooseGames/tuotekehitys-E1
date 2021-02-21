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
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerCamera.transform.position = this.gameObject.transform.position; 
    }
}
