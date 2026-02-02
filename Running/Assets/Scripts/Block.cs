using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Transform backTrs;

    public bool isDestroy = false;

    private void Start()
    {
       backTrs = Camera.main.transform.GetChild(1);
    }

    void Update()
    {
        if (transform.position.x + (transform.localScale.x * 0.5) < backTrs.position.x)
        {
            Destroy(gameObject);
        }
    }

    /*
    
    어떤 조건이 됐을 때 스스로를 지워야 한다.
    카메라에서 벗어나서 어느 정도 멀어졌을 때
    스스로를 지운다.

    Destroy(gameObject);

    */
}
