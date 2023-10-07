using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class timer : MonoBehaviour
{
    public float InitialDuration = 60f;
    public float CurrenTime = 0f;
    private bool timeUp = false;

    private timer _timer;
    public float TimeLeft;
    public TMP_Text Text;

    // Start is called before the first frame update
    void Start()
    {
        CurrenTime = InitialDuration;
        _timer = FindObjectOfType<timer>();
        TimeLeft = CurrenTime;
    }

    // Update is called once per frame
    void Update()
    {
        //the game is over, should stop game
        if (CurrenTime <= 0 && timeUp == false)
        {
            Debug.Log("Times UP");
            timeUp = true;
            SceneManager.LoadScene("end menu");
            return;
        }
        TimeCounter();
        Timer();
    }

    public void TimeCounter()
    {
        CurrenTime -= Time.deltaTime;       
    }

    public void Timer()
    {
        Debug.Log("Timer " + CurrenTime);

        if (_timer != null)
        {
            _timer.TimeCounter();
        }

        if (Text != null)
        {
            Text.text = "Time Left: " + ((int)CurrenTime).ToString();
        }

    }
}
