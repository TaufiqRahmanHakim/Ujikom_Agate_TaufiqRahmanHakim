using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tmpTimer;
    public TextMeshProUGUI tmpScoreGameOver;

    [SerializeField] private GameObject GameOver;

    private bool flagGameOver = false;


    [SerializeField] private float timer;

    private void Update()
    {
        timer -= 1f * Time.deltaTime;
        tmpTimer.text = timer.ToString();

        if (timer <= 0 && !flagGameOver)
        {
            GameOver.SetActive(true);
            //Time.timeScale= 0f;
            tmpScoreGameOver.text = "Score : " + Score.Instance.scoreValue;
            flagGameOver = true;
        }
    }
}
