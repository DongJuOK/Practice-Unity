using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMaker : MonoBehaviour
{
    [SerializeField] GameObject startBlock;
    [SerializeField] GameObject coin;
    [SerializeField] GameObject PF_block;
    [SerializeField] GameObject forwardCube;
    [SerializeField] float scaleMinX;
    [SerializeField] float scaleMaxX;

    GameObject obj;
    float currentEndX;

    void Start()
    {
        currentEndX = startBlock.transform.position.x + (startBlock.transform.localScale.x * 0.5f);
        obj = startBlock;
    }

    void Update()
    {
        if (obj.transform.position.x + (obj.transform.localScale.x * 0.5) < forwardCube.transform.position.x)
        {
            Make();
        }
    }

    void Make()
    {
        float scaleX = Random.Range(scaleMinX, scaleMaxX);

        float rand = Random.Range(1f, 2f);

        float halfwidth = scaleX * 0.5f;

        float spawnX = currentEndX + rand + halfwidth;

        Vector3 pos = new Vector3(spawnX, Random.Range(-1f, 1f), 0f);

        obj = Instantiate(PF_block, pos, Quaternion.identity);

        obj.transform.localScale = new Vector3(scaleX, 1f, 1f);

        currentEndX = spawnX + halfwidth;
    }
}
