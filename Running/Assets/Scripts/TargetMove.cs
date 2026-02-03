using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MoveFunc();
    }

    void MoveFunc()
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
    }
}
