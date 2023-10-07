using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] myObjects;
    Vector3 spawn = new Vector3(-8f, 5f, 0f);
    public float interval = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval){
        int ranIndex = Random.Range(0, myObjects.Length);
        Instantiate(myObjects[ranIndex], spawn, Quaternion.identity);
        timer = 0f;

        }
    }


}
