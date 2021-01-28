using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    Rigidbody2D AK47;
    void Start()
    {
        AK47 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AK47.AddForce(new Vector2(2, 0));
    }
}
