using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PajaroSalto : MonoBehaviour
{
    public float ySpeed;
    public float yTarget;
    public GameObject soundBounce;
    
    void Update()
    {
        transform.Translate(0, ySpeed, 0);
        ySpeed = Mathf.Lerp(ySpeed, yTarget, .025f);

        if (Input.GetKeyDown("space"))
        {
            Instantiate(soundBounce, transform.position, transform.rotation);
            ySpeed = .05f;
        }
    }
}
