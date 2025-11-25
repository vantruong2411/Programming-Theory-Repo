using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;

    public Vector3 areaSize = new Vector3(5, 5, -4);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnRandomShape();
        }
    }

    void SpawnRandomShape()
    {
        int type = Random.Range(0, 3);
        GameObject prefab = null;

        switch (type)
        {
            case 0: prefab = cubePrefab; break;
            case 1: prefab = spherePrefab; break;
            case 2: prefab = capsulePrefab; break;
        }

        Vector3 pos = new Vector3(
            Random.Range(-areaSize.x, areaSize.x),
            Random.Range(-areaSize.y, areaSize.y),
            -1f
        );

        Instantiate(prefab, pos, Quaternion.identity);
    }
}
