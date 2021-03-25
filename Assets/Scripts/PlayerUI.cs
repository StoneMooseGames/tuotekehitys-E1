using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{
    public Image healthBar;
    
    public TextMeshProUGUI dynamite;
    public TextMeshProUGUI points;

    
    public void SetHealthFill(float value)
  {
    healthBar.fillAmount = value;
  }
  
  public void SetDynamite(int value)
  {
    dynamite.text = value.ToString();
  }
  public void SetPoints(int value)
    {
        Debug.Log(value);
        int.TryParse(points.text, out int temp);
        temp = temp + value;
        points.text = temp.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape")) SceneManager.LoadScene("Menu");
       
    }
    
}
