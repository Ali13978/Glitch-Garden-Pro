using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float fireSpeed = 1f;
    [SerializeField] int ProjectileDamage = 1;

private void OnTriggerEnter2D(Collider2D Collision)
{
  if(Collision.tag == "Enemy")
  {
    GameObject Attacker = Collision.gameObject;
    Attacker.GetComponent<EnemyDamage>().Enemydamage(ProjectileDamage);
  }
}

    void Update()
    {
        transform.Translate(Vector2.right*fireSpeed*Time.deltaTime);
    }
}
