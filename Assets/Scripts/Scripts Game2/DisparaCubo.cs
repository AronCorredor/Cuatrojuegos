using UnityEngine;

public class DisparaCubo : MonoBehaviour
{
    [Header("Informacion")]
    public GameObject Proyectil;
    public Transform spawnPoint;

    [Header("Fuerzas")]
    public float shotForce = 3000;
    public float shotRate = 0.3f;

    private float shotRateTime = 0;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;

                newBullet = Instantiate(Proyectil, spawnPoint.position, spawnPoint.rotation);

                shotRateTime = Time.time + shotRate;

            }

        }
    }
}
