using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using static EspressoMachine;

public class Esptimer : MonoBehaviour
{
    public EspressoMachine espresso;

    public float StartTime;
    private int i;

    [Header("Time Settings")]
    public bool countDown;
    public float currentTimeEsp;


    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimitEsp = 15;

    private bool isRunning = false;
    private bool check_espresso = false;

    [Header("Time")]
    public string minute = "0";
    public string second = "0";

    [Header("Time Text")]
    public TextMeshProUGUI timerTextEsp;


    [Header("Object Manage")]
    public GameObject shot_flow;

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
           currentTimeEsp = StartTime * 60;
            shot_flow.SetActive(true);

        }

       

    }

    public void TimerStop()
    {
        if (isRunning)
        {
            print("stop");
            isRunning = false;
            currentTimeEsp = 0;
            espresso.shot_esp.SetActive(true);
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
      timerTextEsp.text = minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0'); // 13:44:13     
    }



    // Update is called once per frame
    void Update()
    {
        

        int m = Convert.ToInt16(minute);
        int s = Convert.ToInt16(second);

        if (isRunning)
        {
            //----EspressoTimer----
           
            currentTimeEsp = countDown ? currentTimeEsp -= Time.deltaTime : currentTimeEsp += Time.deltaTime;

                s = Convert.ToInt16(currentTimeEsp);
                second = Convert.ToString(s);
                minute = Convert.ToString(m);
            if (hasLimit && ((countDown && currentTimeEsp <= timerLimitEsp || (!countDown && currentTimeEsp >= timerLimitEsp))))
            {
                

                if (currentTimeEsp != 0)
                {
                    currentTimeEsp = timerLimitEsp;
                    shot_flow.SetActive(false);
                    check_espresso = true;
                }

                if (i != 0)
                {  
                    check_espresso = false;
                    currentTimeEsp = timerLimitEsp;
                    i = 0;
                }
                i++;
                TimerStop();
            }
                
            SetTimerText();
        }
    }
}
