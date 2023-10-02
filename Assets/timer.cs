using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    public float InitialDuration = 60f;
    public float CurrenTime = 0f;
    private bool timeUp = false;

    // Start is called before the first frame update
    void Start()
    {
        CurrenTime = InitialDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //the game is over, should stop game
        if (CurrenTime <= 0 && timeUp == false)
        {
            Debug.Log("Times UP");
            timeUp = true;
            return;
        }

        CurrenTime -= Time.deltaTime;
    }
}
