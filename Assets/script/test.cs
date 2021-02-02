using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string NISSAN = "";
        for (int x=1; x<101; x+= 2)
        {
            NISSAN += x.ToString() + ", ";
        }
        Debug.Log(NISSAN);
    }

    
}
