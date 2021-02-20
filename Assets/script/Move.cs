using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 20f;
    public float jumpforce = 40f;
    private Rigidbody2D rigidbody2d;
    float move = 0f;
    Object bullet556;

    void Start()
    {
        bullet556 = Resources.Load("jumpfire");
    }
    private void Awake()
    {
        rigidbody2d= transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(move,0,0) * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 10f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            GameObject bullet = (GameObject)Instantiate(bullet556);
            bullet.transform.position = new Vector3(transform.position.x + .2f, transform.position.y - .4f, -1);
        }
    }
}
