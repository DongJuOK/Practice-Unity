using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMaker : MonoBehaviour
{
    public GameObject PF_Block;

    void Start()
    {
        GameObject obj = Instantiate(PF_Block);

        obj.transform.position = new Vector3(11f, -0.5f, 0f);
    }

    void Update()
    {
        
    }
}
