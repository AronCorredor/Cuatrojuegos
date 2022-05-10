using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajaroCollision : MonoBehaviour
{
    public GameObject checkpointSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ambiente")
        {
            Destroy(gameObject);
        }


        else if (other.gameObject.tag == "checkpoint")
        {
            Instantiate(checkpointSound, transform.position, transform.rotation);
        }
    }
}


