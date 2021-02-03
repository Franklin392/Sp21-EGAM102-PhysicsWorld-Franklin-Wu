using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class straightline : MonoBehaviour
{
    public GameObject ObjectToClone;
    public float XMin, XMax, XStep;
    public float YJitter;
    public float Slope, Intercept;
    void Start()
    {
        GameObject CCCP;
        float 
              x,
              y,
              z;
        z = 0;
         for(x = XMin; x < XMax; x += XStep)
        {
            CCCP = Instantiate(ObjectToClone, this.transform);
            y = 6 * x + 6;
            CCCP.transform.position = new Vector3(x, y, z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
