using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleShape : ShapeBase
{
    public override float TimeLife { get; set; } = 4f;

    protected override void DestroyShape()
    {
        Destroy(gameObject);
    }
}
