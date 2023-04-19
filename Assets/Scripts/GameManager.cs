using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //public GameObject eggPrefab;
    //public GameObject flourPrefab;

    //public Transform eggSpot;
    //public Transform flourSpot;

    public GameObject gameOver;

    public float timerSet;
    float timer;

    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timer = timerSet;
        timerText.text = "Timer: " + timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            JamThemeRevel();
        }
        float seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = "Timer: " + seconds;
    }















    void JamThemeRevel()
    {
        gameOver.SetActive(true);
    }
}
