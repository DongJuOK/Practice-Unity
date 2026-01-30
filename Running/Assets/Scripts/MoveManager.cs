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

    void Update()
    {
        MoveFunc(cameraTrs);
        MoveFunc(charTrs);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpFunc();
        }
    }

    private void MoveFunc(Transform trs)
    {
        Vector3 pos = trs.position;
        pos.x += speed * Time.deltaTime;
        trs.position = pos;
    }

    private void JumpFunc()
    {
        // Rigidbody rigid = charTrs.GetComponent<Rigidbody>();

        Vector3 power = new Vector3(0f, m_jumpPower, 0f);

        // charRigid.AddForce(power);
        charRigid.velocity = power;
    }
}
