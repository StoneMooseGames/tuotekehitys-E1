using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
  public Image healthBar;
  public TextMeshProUGUI ammo;
  public TextMeshProUGUI dynamite;
  public void SetHealthFill(float value)
  {
    healthBar.fillAmount = value;
  }
  public void SetAmmo(int value)
  {
    ammo.text = value.ToString();
  }
  public void SetDynamite(int value)
  {
    dynamite.text = value.ToString();
  }
}
