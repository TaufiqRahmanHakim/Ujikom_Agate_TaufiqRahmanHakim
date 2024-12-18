using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [SerializeField] private GameObject throwObject;
    [SerializeField] private Transform targetObject;

    private void Throw()
    {
        Instantiate(throwObject, gameObject.transform.position, Quaternion.identity);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("fdddf");
            Throw();
        
        }
    }

}
