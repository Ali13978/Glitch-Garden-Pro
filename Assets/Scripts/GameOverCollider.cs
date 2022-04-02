using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverCollider : MonoBehaviour
{
  public TextMeshProUGUI HealthText;
  int Health = 300;
private void OnTriggerEnter2D(Collider2D Collision)
{
  if(Collision.tag == "Enemy")
  {
    Health = Health - 100;
    UpdateHealthText();
    Destroy(Collision.gameObject);
    if(Health<1)
    {
      FindObjectOfType<levelController>().truelooselabel();
    }
  }
}

private void UpdateHealthText()
{
  HealthText.text = Health.ToString();
}

}
