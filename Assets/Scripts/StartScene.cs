using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField PlayerName;
    string Playername;

    private void SetPlayerName()
    {
        Playername = PlayerName.text;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetPlayerName();
    }
}
