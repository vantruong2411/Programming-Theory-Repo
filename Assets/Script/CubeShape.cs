using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : ShapeBase
{
    public override float TimeLife { get; set; } = 2f;

        protected override void DestroyShape()
    {
        Destroy(gameObject);
    }
}
