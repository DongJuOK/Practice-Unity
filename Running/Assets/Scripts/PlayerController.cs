using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float jumpPower;
    bool isJump;
    int count;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump && count < 2)
        {
            JumpFunc();
        }
    }

    void JumpFunc()
    {
        Vector3 power = new Vector3(rb.velocity.x, jumpPower, rb.velocity.z);

        rb.AddForce(power);

        count++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJump = false;
        count = 0;
    }
}
