using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int EnemyHealth = 4;
    [SerializeField] GameObject deathvfx;
    DeathVFX VFXDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zuchini")
        {
            Destroy(collision.gameObject);
        }
           DealDamage();
    }

public void Enemydamage(int Damage)
{
  EnemyHealth = EnemyHealth - Damage;
}

private void DealDamage()
{
  if(EnemyHealth<=0)
  {
    GetComponent<AudioSource>().Play();
  Destroy(gameObject,0.4f);
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
