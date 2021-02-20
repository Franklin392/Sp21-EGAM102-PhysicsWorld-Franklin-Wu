using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
        Object bullet556;
    void Start()
    {
        bullet556 = Resources.Load("jumpfire");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            GameObject bullet = (GameObject)Instantiate(bullet556);
            bullet.transform.position = new Vector3(transform.position.x + .2f, transform.position.y + .4f, -1);
        }
    }
}
