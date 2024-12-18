using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]private AnimalType animalType;




    private Rigidbody rb;

    [SerializeField] private float speedMovement;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        

        switch (animalType)
        {
            case AnimalType.cow:
                speedMovement = 5f;
                break;
            case AnimalType.deer:
                speedMovement = 7f;
                break;
            case AnimalType.dog:
                speedMovement = 10f;
                break;

        }
    }


    private void FixedUpdate()
    {
        

        rb.velocity = new Vector3(0, 0, -1f * speedMovement);
    }
}

public enum AnimalType
{
    cow, deer, dog
}
