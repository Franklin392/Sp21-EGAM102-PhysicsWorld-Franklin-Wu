using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    public float MovementStrength;
    public float jumpSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D LS;
            LS = GetComponent<Rigidbody2D>();
            LS.velocity = (Vector2.up * jumpSpeed);
        }

    }
    private void FixedUpdate()
    {
          if(Input.GetKey(KeyCode.D)) 
            {
            Rigidbody2D HEMI;
            HEMI = GetComponent<Rigidbody2D>();
            HEMI.AddForce(MovementStrength * Vector3.right,ForceMode2D.Force);
            }
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody2D HEMI;
            HEMI = GetComponent<Rigidbody2D>();
            HEMI.AddForce(MovementStrength * Vector3.left, ForceMode2D.Force);
        }
     
        
        }
    }

