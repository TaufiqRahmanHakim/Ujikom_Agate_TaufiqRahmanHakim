using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float speedMovement;
    [SerializeField] private Animator animator;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float movementY = Input.GetAxis("Horizontal");

        animator.SetFloat("Horizontal", movementY);

        Debug.Log(movementY);

        rb.velocity = new Vector3 (movementY * speedMovement, 0, 0);
    }


}
