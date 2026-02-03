using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Transform backCube;

    void Start()
    {
        backCube = Camera.main.transform.GetChild(1);
    }

    void Update()
    {
        if (transform.position.x + (transform.localScale.x * 0.5f) < backCube.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
