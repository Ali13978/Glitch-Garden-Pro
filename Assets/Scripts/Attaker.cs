using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attaker : MonoBehaviour
{

float CurrentSpeed = 1f;
GameObject currentTarget;

private void Awake()
{
  FindObjectOfType<levelController>().AddNumberOfaliveEnemies();
}

private void OnDestroy()
{
  FindObjectOfType<levelController>().SubtractNumberOfaliveEnemies();
}

    void Update()
    {
        transform.Translate(Vector2.left * CurrentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }
private void UpdateAnimationState()
{
  if(!currentTarget)
  {
    GetComponent<Animator>().SetBool("IsAttacking",false);
  }
}
public void SetMovementSpeed(float speed)
    {
        CurrentSpeed = speed;
    }
public void attaking(GameObject Target)
{
  GetComponent<Animator>().SetBool("IsAttacking",true);
  currentTarget = Target;
}
public void EndAttackingAnimation()
{
  GetComponent<Animator>().SetBool("IsAttacking",false);
}
public void StrikeCurrentTarget(float Damage)
{
  if(!currentTarget)
  {return;}
  Health healt = currentTarget.GetComponent<Health>();
  if(healt)
  {
    healt.Damagedealer(Damage);
  }
}
}
