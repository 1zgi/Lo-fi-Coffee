using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Tiktokmachine : MonoBehaviour
{

    public float StartTime;
 
    [Header("Time Settings")]
    public bool countDown;
    public float currentTimeFilter;


    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimitFilter;

    private bool isRunning = false;

    [Header("Time")]
    public string minute = "0";
    public string second = "0";

    [Header("Time Text")]
    public TextMeshProUGUI timerTextFilt;

    [Header("Object Manage")]
    public GameObject acýk_button;
    public GameObject kapali_button;
    public GameObject coffee_full;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void TimerStart()
    {

        if (!isRunning)
        {
           print("Start");
           isRunning = true;
           currentTimeFilter = StartTime * 60;
            
                
        }
    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("stop");
            currentTimeFilter = 0;
            kapali_button.SetActive(true);    
            isRunning = false;
            TimerReset();
        }

    }

    public void TimerReset()
    {
        print("reset");
        int m = Convert.ToInt16(minute);
        int s = Convert.ToInt16(second);
        m = 0;
        s = 0;
        minute = Convert.ToString(m);
        second = Convert.ToString(s);
        SetTimerText();
    }

    private void SetTimerText()
    {
      timerTextFilt.text = minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0'); // 13:44:13
 
    }


    // Update is called once per frame
    void Update()
    {
        int m = Convert.ToInt16(minute);
        int s = Convert.ToInt16(second);

        if (isRunning)
        {
            //----FilterTimer----
            currentTimeFilter = countDown ? currentTimeFilter -= Time.deltaTime : currentTimeFilter += Time.deltaTime;

            s = Convert.ToInt16(currentTimeFilter);
            second = Convert.ToString(s);
            minute = Convert.ToString(m);

            if (hasLimit && ((countDown && currentTimeFilter <= timerLimitFilter || (!countDown && currentTimeFilter >= timerLimitFilter))))
            {
                if (currentTimeFilter != 0)
                {
                    currentTimeFilter = timerLimitFilter;
                    acýk_button.SetActive(false);
                    coffee_full.SetActive(true);
                }
                TimerStop();
            }
            SetTimerText();
        }
    }
}