using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameCompleted : MonoBehaviour
{
    public TextMeshProUGUI GameCompletede;
    public GameObject StartButton;
    // Start is called before the first frame update
    void Start()
    {
      StartButton.SetActive(false);
        StartCoroutine(FinalLoading());
    }

    IEnumerator Loading1()
    {
        GameCompletede.text = ("GameCompleted.");
        yield return new WaitForSeconds(1f);
        GameCompletede.text = ("GameCompleted..");
    }

    IEnumerator Loading2()
    {
        StartCoroutine(Loading1());
        yield return new WaitForSeconds(2f);
        GameCompletede.text = ("GameCompleted...");
    }

    IEnumerator FinalLoading()
    {
        StartCoroutine(Loading1());
        StartCoroutine(Loading2());
        yield return new WaitForSeconds(3f);
        StartButton.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
