using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Attaker [] AttackerprefabArray;
    [SerializeField] float minSpawnDelay = 2;
    [SerializeField] float maxSpawnDelay = 5;
    [SerializeField] int NumberOfEnemies = 7;
    bool SpawnEnemies = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {

        for (int a = 1; a <= NumberOfEnemies; a++)
            {
                yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
                NumberOfEnemies ++;
                SpawnEnemie();
            }
    }

    public void StopSpawningEnemies()
    {
      SpawnEnemies = false;
    }

    private void SpawnEnemie()
    {
      if(SpawnEnemies == true)
      {
      var AttackerprefabArrayIndex = Random.Range(0, AttackerprefabArray.Length);
      Spawn(AttackerprefabArray[AttackerprefabArrayIndex]);
      }
    }

   private void Spawn(Attaker Myattaker)
   {
     Attaker newAttaker = Instantiate(Myattaker, transform.position, transform.rotation);
     newAttaker.transform.parent = transform;
   }
}
