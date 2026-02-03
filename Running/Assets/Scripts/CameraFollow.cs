using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
