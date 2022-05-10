using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajaroObstaculo : MonoBehaviour
{
    public float sendTimer = 1;
    public float frecuencia = 2;
    public float posicion;
    public GameObject miObstaculo;
    public GameObject personajePrincipal;

    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            posicion = Random.Range(.68f, 2f);
            transform.position = new Vector3(0, posicion, -3.7f);
            Instantiate(miObstaculo, transform.position, transform.rotation);
            sendTimer = frecuencia;
        }
        if (personajePrincipal != null) Time.timeScale = 1;
        else Time.timeScale = 0;
    }
}
