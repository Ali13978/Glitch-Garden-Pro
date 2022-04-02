using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
  GameObject DefenderToAttack;
private void OnTriggerEnter2D(Collider2D collision)
{
  DefenderToAttack = collision.gameObject;
  if(collision.tag == "Defender")
  {
    GetComponent<Attaker>().attaking(DefenderToAttack);
  }
  if(collision.tag == "GraveStone")
  {
    TriggerJumpingAnimation();
  }
}

private void TriggerJumpingAnimation()
{
  if(DefenderToAttack.tag == "GraveStone")
  {
    GetComponent<Animator>().SetBool("IsJumping",true);
  }
}
public void ExitjumpAnimation()
{
  GetComponent<Animator>().SetBool("IsJumping",false);
}
}
