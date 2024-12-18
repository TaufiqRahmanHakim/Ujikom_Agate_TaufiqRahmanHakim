using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Score.Instance.addScore();
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0f,0f,10f);
    }
}
