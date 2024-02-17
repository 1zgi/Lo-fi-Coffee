using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float startTime;
    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Limit Settings")]
    public bool hasLimit;
    public float timerLimit;

    [Header("Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();

    [Header("Time")]
    public string hour;
    public string minute;

    void Start()
    {
        currentTime = startTime * 60 * 60;
        timeFormats.Add(TimerFormats.Whole,"0");
        timeFormats.Add(TimerFormats.TenthDecimal,"0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal,"0.00");
    }

    
    void Update()
    {
        int m = Convert.ToInt16(minute);
        int h = Convert.ToInt16(hour);
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
   
            if (hasLimit && ((countDown && currentTime <= timerLimit || (!countDown && currentTime >= timerLimit))))
            {
                currentTime = timerLimit;
                m += 1;

               if (m == 60)
               {
                   m = 0;
                   h += 1;
                   hour = Convert.ToString(h);
                   SetTimerText();
               }
                minute = Convert.ToString(m);
                SetTimerText();
                currentTime = 0;    
            }

            if(h==18)
            {
            enabled = false;
            timerText.color = Color.red;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        SetTimerText();
      
    }

    private void SetTimerText()
	{
        
        //timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
        timerText.text = hour.ToString().PadLeft(2,'0') + ":" + minute.ToString().PadLeft(2,'0'); // 13:44:13
    }
    
    public enum TimerFormats
	{
        Whole,
        TenthDecimal,
        HundrethsDecimal
	}
}
