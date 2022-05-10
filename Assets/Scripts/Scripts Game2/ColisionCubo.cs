using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCubo : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
          Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("Bola"))
        {
            rb.isKinematic = true;
        }
    }
}
