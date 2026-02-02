using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PathMaker : MonoBehaviour
{
    [SerializeField] GameObject StartBlock;

    [SerializeField] GameObject PF_Block;

    [SerializeField] GameObject ForwardCube;

    GameObject obj;

    float currentEndX;

    private void Start()
    {
        currentEndX = StartBlock.transform.position.x + (StartBlock.transform.localScale.x * 0.5f);
        obj = StartBlock;
    }

    void Update()
    {
        if (obj.transform.position.x + (obj.transform.localScale.x * 0.5) < ForwardCube.transform.position.x)
        {
            TempFunc();
        }
    }

    private void TempFunc()
    {
        float randValue = Random.Range(1f, 2f);

        float halfWidth = PF_Block.transform.localScale.x * 0.5f;

        float spawnX = currentEndX + randValue + halfWidth;

        Vector3 pos = new Vector3(spawnX, Random.Range(-1f, 1f), 0f);

        obj = Instantiate(PF_Block, pos, Quaternion.identity);

        currentEndX = spawnX + halfWidth;
    }

    /*
    
    1. 뒤에 남아있는 블록은 시야에서 안보이고 멀어지면 지운다. - (Block 스스로 지우기)
    2. 앞에는 보이기전에 미리 길을 만들어 놓는다. (PathMaker 만들게)
    3. transform의 pos값(x, y)과 scale(x)가 적절하게 달라야한다.

    */
}
