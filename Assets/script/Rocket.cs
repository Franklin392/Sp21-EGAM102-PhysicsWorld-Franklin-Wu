using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public GameObject ExplosionPiecePrefab;

    public Vector3 RocketForce;
    public float RocketDuration; //Rocket engine burns fot this long

    public float ExplosionForce;
    public float ExplosionDelay; // rocket explodes after explosiondelay seconds

    private float ExplosionTime;

    private float RocketCutoffTime;
    void Start()
    {
        ExplosionTime = Time.time + ExplosionDelay;
        RocketCutoffTime = Time.time + RocketDuration;
    }
    GameObject newExplosionPiece;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time < RocketCutoffTime)
        {
            GetComponent<HomeBrewRigidbody2D>().TotalForce += RocketForce;
        }
        if (Time.time > ExplosionTime)
        {
            for (int i = 0; i < 50; i++)
            {
                newExplosionPiece = Instantiate(ExplosionPiecePrefab); // Make a new things
                newExplosionPiece.transform.position = this.transform.position;  // start where u are
                newExplosionPiece.GetComponent<HomeBrewRigidbody2D>().velocity = this.GetComponent<HomeBrewRigidbody2D>().velocity; // start with velocity
                newExplosionPiece.GetComponent<HomeBrewRigidbody2D>().TotalForce = ExplosionForce * Random.insideUnitCircle; // ADD force go into random direction
            }
            Destroy(this.gameObject); // boooom!
        }
    }
}
