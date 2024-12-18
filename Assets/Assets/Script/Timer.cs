using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.IO.LowLevel.Unsafe;
using UnityEditor.Rendering;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tmpTimer;
    public TextMeshProUGUI tmpScoreGameOver;

    [SerializeField] private GameObject camera1;
    [SerializeField] private GameObject camera2;

    [SerializeField] private GameObject GameOver;

    private bool flagGameOver = false;

    [SerializeField] private Animator animator;


    [SerializeField] private float timer;

    private void Start()
    {
        camera2.SetActive(false);
        camera1.SetActive(true);
    }

    private void Update()
    {
        timer -= 1f * Time.deltaTime;
        tmpTimer.text = timer.ToString();

        if (timer <= 0 && !flagGameOver)
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            GameOver.SetActive(true);
            animator.SetBool("GameOver", true);
            //Time.timeScale= 0f;
            tmpScoreGameOver.text = "Score : " + Score.Instance.scoreValue;
            flagGameOver = true;
        }
    }
}
