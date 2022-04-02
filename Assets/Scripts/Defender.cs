using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;
    GameObject Attacker;
    bool SelectShovel = false;

public int GetStarCost()
{
  return starCost;
}
public void AddStars(int amount)
{
  FindObjectOfType<StarsDisplay>().AddStars(amount);
}

private void OnColliderEnter2D(Collider2D Collision)
{
  if(Collision.tag == "Enemy")
  {
    Attacker = Collision.gameObject;
  }
}
}
