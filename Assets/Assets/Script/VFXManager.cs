using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public static VFXManager instance {  get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    [SerializeField] private GameObject vfxGotDestroyed;

    public void SpawnVFX(Transform transform)
    {
        Instantiate(vfxGotDestroyed, transform);
    }
}
