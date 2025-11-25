using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShapeBase : MonoBehaviour
{
    [SerializeField]
    private float timeLife = 1f;

    // Encapsulation: đảm bảo giá trị an toàn
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

    // Abstraction: lớp con bắt buộc phải có hành động destroy
    protected abstract void DestroyShape();
}
