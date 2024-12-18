using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] private AudioSource animalDestroyed;

    public static SFXManager instance {  get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void playDestroyed()
    {
        animalDestroyed.Play();
    }
}
