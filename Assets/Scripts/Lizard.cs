using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
  GameObject DefenderToAttack;
private void OnTriggerEnter2D(Collider2D collision)
{
  DefenderToAttack = collision.gameObject;
  if(collision.tag == "Defender" || collision.tag == "GraveStone")
  {
    GetComponent<Attaker>().attaking(DefenderToAttack);
  }
}
}
