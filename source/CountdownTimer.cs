using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 34f;
    private Text timerSeconds;
    
    void Start()
    {
        timerSeconds = GetComponent<Text>();
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f2");
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
    }
}
