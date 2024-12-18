using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tmpTimer;

    [SerializeField] private float timer;

    private void Update()
    {
        timer -= 1f * Time.deltaTime;
        tmpTimer.text = timer.ToString();

        if (timer <= 0)
        {
            //GameOver
        }
    }
}
