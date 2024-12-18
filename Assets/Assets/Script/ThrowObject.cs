using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [SerializeField] private GameObject throwObject;
    [SerializeField] private Transform targetObject;
    [SerializeField] private Animator animator;

    [SerializeField] private float delayThrow;

    private void Throw()
    {
        Instantiate(throwObject, gameObject.transform.position, Quaternion.identity);
        Invoke("animatorSthrowFlag", 0.5f);
    }
    private void Update()
    {
        if (delayThrow > 0) {
            delayThrow -= 1f * Time.deltaTime;
            
        }

        if (Input.GetKeyDown(KeyCode.Space) && delayThrow <= 0) {
            animator.SetBool("Throw",true);
            Debug.Log("fdddf");
            Throw();
            delayThrow = 3f;
        
        }
    }
    private void animatorSthrowFlag()
    {
        animator.SetBool("Throw", false);
    }
}
