using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
  [SerializeField] float health;
  [SerializeField] GameObject deathvfx;
  DeathVFX VFXDestroy;
public void Damagedealer(float damage)
{
  health = health - damage;
  if(health<=0)
  {
  Destroy(gameObject);
  DeathVFX();
  }
}


  private void DeathVFX()
  {
      Instantiate(deathvfx, transform.position, transform.rotation);
      VFXDestroy = GameObject.FindGameObjectWithTag("DeathVFX").GetComponent<DeathVFX>();
      VFXDestroy.DestroyVFX();
  }
}
