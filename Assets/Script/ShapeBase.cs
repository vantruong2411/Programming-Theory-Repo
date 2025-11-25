using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public abstract class ShapeBase : MonoBehaviour
{
    [SerializeField]
    private float timeLife = 1f;

    //ENCAPSULATION
    public virtual float TimeLife
    {
        get => timeLife;
        set => timeLife = Mathf.Clamp(value, 0.1f, 10f);
    }

    private float timer = 0f;

    protected virtual void Update()
    {
        timer += Time.deltaTime;

        if (timer >= TimeLife)
        {
            DestroyShape();
        }
    }

    //ABSTRACTION
    protected abstract void DestroyShape();
}
