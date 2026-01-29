using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    [SerializeField] Transform cameraTrs;
    [SerializeField] Transform charTrs;
    [SerializeField] float speed;

    void Update()
    {
        Vector3 cameraPos = cameraTrs.position;
        cameraPos.x += speed * Time.deltaTime;
        cameraTrs.position = cameraPos;

        Vector3 charPos = charTrs.position;
        charPos.x += speed * Time.deltaTime;
        charTrs.position = charPos;
    }
}
