using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PressStart()
  {
    SceneManager.LoadScene("level1"); 
  }
public void PressExit()
  {
    Application.Quit();
  }
}
