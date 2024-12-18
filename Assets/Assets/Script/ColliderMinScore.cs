using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderMinScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(Score.Instance.scoreValue != 0)
        {
            Score.Instance.min3Score();

        }
        Destroy(other.gameObject);
    }
}
