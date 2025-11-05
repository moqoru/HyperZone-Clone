using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region 변수
    [Header("게임 설정")]
    [Tooltip("현재 스테이지의 제한 이동 횟수")]
    public float moveSpeed = 10f;
    #endregion // 변수
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float fHorizontal = Input.GetAxisRaw("Horizontal");
        float fVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(fHorizontal, fVertical, 0f);


        if (movement.magnitude > 1.0f)
        {
            movement.Normalize();
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime);

    }
}
