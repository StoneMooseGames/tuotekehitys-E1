using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class tutorialManager : MonoBehaviour
{
    public GameObject[] tutorials;
    int tutorialStage = 0;
    GameObject player;
    public GameObject endObject;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        

        for (int i = 0; i < tutorials.Length; i++)
        {
            tutorials[i].GetComponent<TMP_Text>().text = "";
        }
        tutorials[0].GetComponent<TMP_Text>().text = "Press A and D to move left and right";
        
    }

    // Update is called once per frame
    void Update()
    {
        
            
            if (Input.GetAxisRaw("Horizontal") !=0 && tutorialStage == 0)
            {
                tutorials[0].GetComponent<TMP_Text>().text = "";
                tutorials[1].GetComponent<TMP_Text>().text = "Press Space to use jetpack";
                tutorialStage = 1;
            }
            if (Input.GetKey("space") && tutorialStage == 1)
            {
                tutorials[1].GetComponent<TMP_Text>().text = "";
                tutorials[2].GetComponent<TMP_Text>().text = "Press Left mouse button to fire";
                tutorialStage = 2;
            }

            if (Input.GetMouseButtonDown(0) && tutorialStage == 2)
            {
                tutorials[1].GetComponent<TMP_Text>().text = "";
                tutorials[2].GetComponent<TMP_Text>().text = "Press Right mouse button to drop dynamite";
                tutorialStage = 3;
            }

            if (Input.GetMouseButtonDown(1) && tutorialStage == 3)
            {
                tutorials[1].GetComponent<TMP_Text>().text = "";
                tutorials[2].GetComponent<TMP_Text>().text = "Find the lost miner";
                tutorialStage = 4;
            }

            if(player.GetComponent<Collider2D>().IsTouching(endObject.GetComponent<Collider2D>()))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    
}
