using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static MusicManager;

public class ScoreManager : MonoBehaviour
{
    MusicManager music;
    bool isScorecame  = false;
    public float volume;
    private int TotalScore = 0;
    public TextMeshProUGUI ScoreText;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " +  TotalScore;
    }

    public void AddScore(int points)
	{
        isScorecame = true;
        TotalScore += points;
        SoundMoney();
    }

    public void SoundMoney()
	{
        /*
        if(isScorecame)
		{
            music.playEarnMoneySound();
        }*/
        
        isScorecame = false;

    }
}
