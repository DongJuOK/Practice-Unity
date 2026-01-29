using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // 처음 시작했을때 호출되는데 가장 먼저 호출되는 함수
    private void Awake()
    {
        Debug.LogWarning("Awake Method");
    }

    // Start is called before the first frame update
    // 처음 시작했을때 호출되는 함수
    private void Start()
    {
        Debug.LogError("Start Method");
    }

    // Update is called once per frame
    // 매 프레임마다 호출되는 함수
    private void Update()
    {
        Debug.Log("Update Method");
    }
}
