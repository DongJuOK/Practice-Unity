using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveManager : MonoBehaviour
{
    [SerializeField] Transform cameraTrs;
    [SerializeField] Transform charTrs;
    [SerializeField] Rigidbody charRigid;
    [SerializeField] float speed;
    [SerializeField] float m_jumpPower;
    bool isJump;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
        }
    }

    private void FixedUpdate()
    {
        MoveFunc();

        if (isJump)
        {
            JumpFunc();
            isJump = false;
        }
    }

    private void MoveFunc()
    {
        charRigid.velocity = new Vector3(speed, charRigid.velocity.y, charRigid.velocity.z);
    }

    private void JumpFunc()
    {
        // Rigidbody rigid = charTrs.GetComponent<Rigidbody>();

        Vector3 power = new Vector3(charRigid.velocity.x, m_jumpPower, charRigid.velocity.z);

        // charRigid.AddForce(power);
        charRigid.velocity = power;
    }
}
