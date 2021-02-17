using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float Lifetime;
    private float TimeOfDeath;
    void Start()
    {
        TimeOfDeath = Time.time + Lifetime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeOfDeath)
            Destroy(this.gameObject);
    }
}
