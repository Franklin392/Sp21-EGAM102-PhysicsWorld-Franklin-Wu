using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public GameObject ObjectToClone;
    public float XMin, XMax, YMin, Ymax;
    public int NClones;
    public float CloneScaleMin, CloneScaleMax;
    public bool RandomizeSpriteColors;
    void Start()
    {
        GameObject TYPE56;
        for (int RedStar = 0; RedStar < NClones; RedStar++)
        {
            TYPE56 = Instantiate(ObjectToClone, this.transform);
            TYPE56.transform.position = new Vector3(
                 Random.Range(XMin, XMax),
                 Random.Range(YMin, Ymax), 1f);
            TYPE56.transform.localScale = Random.Range(CloneScaleMin, CloneScaleMax) * Vector3.one;

            if (RandomizeSpriteColors)
            {
                TYPE56.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1,
              0, .3f,
              .7f, .9f,
              .3f, .5f);
            }

        }
    }
}
