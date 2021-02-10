using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SquishyBox : MonoBehaviour
{
    public Transform[] CornerObjects;

    private SpriteShapeController SpriteShapeController;
    void Start()
    {
        SpriteShapeController = GetComponent<SpriteShapeController>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteShapeController.spline.SetPosition(0, CornerObjects[0].position);
        SpriteShapeController.spline.SetPosition(0, CornerObjects[1].position);
        SpriteShapeController.spline.SetPosition(0, CornerObjects[2].position);
        SpriteShapeController.spline.SetPosition(0, CornerObjects[3].position);
    }
}
