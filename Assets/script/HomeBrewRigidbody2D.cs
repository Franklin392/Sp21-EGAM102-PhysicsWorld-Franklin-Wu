using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBrewRigidbody2D : MonoBehaviour
{
    public Vector3 velocity;
    public Vector3 acceleration;
    public Vector3 TotalForce;

    public Vector3 Gravity;
    public float mass;

    private void FixedUpdate()
    {
        TotalForce += Gravity;
        transform.position += velocity * Time.fixedDeltaTime;
        velocity += acceleration * Time.fixedDeltaTime;
        acceleration = TotalForce / mass;

        TotalForce = Vector3.zero;
    }

    
    
}
