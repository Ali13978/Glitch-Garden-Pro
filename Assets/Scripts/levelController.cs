using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelController : MonoBehaviour
{    [SerializeField] int AliveNumberOfEnemies = 0;
  bool LevelTimerFinished = false;
  [SerializeField] GameObject winLabel;
  [SerializeField] GameObject LooseLabel;
  bool hascompleted = true;


  private void Start()
  {
    winLabel.SetActive(false);
    LooseLabel.SetActive(false);
  }

  public void truelooselabel()
  {
    LooseLabel.SetActive(true);
    Time.timeScale = 0;
  }

    public void AddNumberOfaliveEnemies()
    {
      AliveNumberOfEnemies++;
    }

    public void MakeLevelTimerFinishedTrue()
    {
      LevelTimerFinished = true;
      StopSpawningEnemies();
    }

    public void SubtractNumberOfaliveEnemies()
    {
      AliveNumberOfEnemies = AliveNumberOfEnemies - 1;
    }

    private void Update()
    {

      if(LevelTimerFinished == true && AliveNumberOfEnemies == 0)
      {
        
        HandleWinCondition();
      }
    }

    private void HandleWinCondition()
    {
      if(hascompleted)
      {
      Time.timeScale = 0;
      winLabel.SetActive(true);
      GetComponent<AudioSource>().Play();
      hascompleted = false;
      }
    }

    public void StopSpawningEnemies()
    {
      EnemySpawner[] spawnersArray = FindObjectsOfType<EnemySpawner>();
      foreach  (EnemySpawner spawner in spawnersArray)
      {
        spawner.StopSpawningEnemies();
      }
    }

}
