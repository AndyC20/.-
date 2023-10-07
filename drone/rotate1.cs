using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate1 : MonoBehaviour
{
    public Vector3 center = new Vector3(0f, 0f, -6f);
    public Vector3 path = Vector3.zero;
    public float speed = 200f;

    void Awake()
    {
        path = new Vector3(Random.Range(30f, 50f) * (Random.Range(0f, 2f) * 2f - 1f), Random.Range(30f, 50f)*(Random.Range(0f, 2f) * 2f - 1f), Random.Range(30f, 50f) * (Random.Range(0f, 2f) * 2f - 1f));
        speed = Random.Range(50f, 100f);
    }


    void Update()
    {
        
        
        transform.RotateAround(center, path, speed * Time.deltaTime);
    }

}
