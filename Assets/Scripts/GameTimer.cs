using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
 [SerializeField] float LevelTimer = 10;
    void Update()
    {
      GetComponent<Slider>().value = Time.timeSinceLevelLoad / LevelTimer;
      bool TimerFinished = (Time.timeSinceLevelLoad>= LevelTimer);
      if(TimerFinished == true)
      {
        FindObjectOfType<levelController>().MakeLevelTimerFinishedTrue();
      }
    }
}
