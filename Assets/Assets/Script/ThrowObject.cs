using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [SerializeField] private GameObject throwObject;
    [SerializeField] private Transform targetObject;
    [SerializeField] private Animator animator;

    private void Throw()
    {
        Instantiate(throwObject, gameObject.transform.position, Quaternion.identity);
        Invoke("animatorSthrowFlag", 0.5f);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            animator.SetBool("Throw",true);
            Debug.Log("fdddf");
            Throw();
        
        }
    }
    private void animatorSthrowFlag()
    {
        animator.SetBool("Throw", false);
    }
}
