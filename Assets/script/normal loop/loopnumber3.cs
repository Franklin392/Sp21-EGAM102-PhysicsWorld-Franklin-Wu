using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopnumber3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string MOPAR = "";
        for (int x = -100; x < 2; x += 2)
        {
            MOPAR += x.ToString() + ", ";
        }
        Debug.Log(MOPAR);
    }

    // Update is called once per frame
   
}
