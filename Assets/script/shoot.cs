using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    Object bullet556;
    void Start()
    {
        bullet556 = Resources.Load("bullet");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = (GameObject)Instantiate(bullet556);
            bullet.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);
        }
    }
}
