using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPElement : MonoBehaviour
{
  [SerializeField] private Image playerImage;
  [SerializeField] private Image healthBar;

  public void SetColor(Color newColor) {
    healthBar.color = newColor;
  }

  public void SetPlayerImage(Sprite image) {
      playerImage.sprite = image;
  }

  public void SetHealthBar(float amount) {
      healthBar.fillAmount = amount;
  }
}
