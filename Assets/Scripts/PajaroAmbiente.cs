using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajaroAmbiente : MonoBehaviour
{

    public float sendTimer = 0;
    public float frecuencia = 9.93f;
    public GameObject floor;

    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            Instantiate(floor, new Vector3(3.9f, -.02f, -12.62f), transform.rotation);
            sendTimer = frecuencia;
        }
    }
}
