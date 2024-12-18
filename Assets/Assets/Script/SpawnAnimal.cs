using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    [SerializeField] private GameObject[] animal;

    [SerializeField]private float timerReset;

    private void Update()
    {
        if(timerReset <= 3f)
        {
            timerReset += 1f * Time.deltaTime;
        }
        else if(timerReset > 2f)
        {
            timerReset = 0;
            SpawnObject();
        }
    }

    private void Start()
    {
        SpawnObject();
    }
    private void SpawnObject()
    {
        Instantiate(animal[Random.Range(0,3)], new Vector3(Random.Range(20f,-20f),transform.position.y, transform.position.z), Quaternion.identity);
    }
}
