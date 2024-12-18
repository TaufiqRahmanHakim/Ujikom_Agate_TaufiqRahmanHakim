using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }    
    }


    public TextMeshProUGUI tmpScore;
    public int scoreValue;

    public void addScore()
    {
        scoreValue++;
        tmpScore.text = scoreValue.ToString();
    }
    public void minScore()
    {
        scoreValue--;
        tmpScore.text = scoreValue.ToString();
    }
    public void min3Score()
    {
        scoreValue -= 3;
        tmpScore.text = scoreValue.ToString();
    }
}
