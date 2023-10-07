using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove : MonoBehaviour
{
    public float min = 10f;
    public float max = 30f;

    void Start()
    {
        float randomTimer = Random.Range(min, max);
        Destroy(gameObject, randomTimer);
    }
}
