using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopnumber2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string TOYOTA = "";
        for (int x = 55; x < 260; x += 5)
        {
            TOYOTA += x.ToString() + ", ";
        }
        Debug.Log(TOYOTA);

    }


}
