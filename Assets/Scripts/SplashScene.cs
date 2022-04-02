using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class SplashScene : MonoBehaviour
{
    public TextMeshProUGUI LoadingText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FinalLoading());
    }

    IEnumerator Loading1()
    {
        LoadingText.text = ("LOADING.");
        yield return new WaitForSeconds(1f);
        LoadingText.text = ("LOADING..");
    }

    IEnumerator Loading2()
    {
        StartCoroutine(Loading1());
        yield return new WaitForSeconds(2f);
        LoadingText.text = ("LOADING...");
    }

    IEnumerator FinalLoading()
    {
        StartCoroutine(Loading1());
        StartCoroutine(Loading2());
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("StartScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
