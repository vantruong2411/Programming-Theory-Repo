using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : ShapeBase
{
    // POLYMORPHISM
    public override float TimeLife { get; set; } = 3f;

    protected override void DestroyShape()
    {
        Destroy(gameObject);
    }
}
