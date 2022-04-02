using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject CactusFire,gun;
    EnemySpawner myLaneSpawner;
    Animator animator;


private void Start()
{
  SetLaneSpawner();
  animator = GetComponent<Animator>();
}

private void Update()
{
  if(IsAttakerInMyLane())
  {
    animator.SetBool("IsAttacking",true);
  }
  else
  {
    animator.SetBool("IsAttacking",false);
  }
}

private void SetLaneSpawner()
{
  EnemySpawner[] Spawners = FindObjectsOfType<EnemySpawner>();
  foreach (EnemySpawner spawner in Spawners)
  {
    bool IsCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y)<= Mathf.Epsilon);
    if(IsCloseEnough == true)
    {
      myLaneSpawner = spawner;
    }
  }
}

private bool IsAttakerInMyLane()
{
  if(myLaneSpawner.transform.childCount<=0)
  {
    return false;
  }
  else
  {
    return true;
  }
}

   public void Fire()
    {
      GetComponent<AudioSource>().Play();
        Instantiate(CactusFire, gun.transform.position, gun.transform.rotation);
    }
}
