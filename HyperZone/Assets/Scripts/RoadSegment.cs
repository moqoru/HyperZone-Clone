using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSegment : MonoBehaviour
{
    public float scrollSpeed = 10f;

    void Update()
    {
        transform.Translate(0, 0, -scrollSpeed * Time.deltaTime);

        // 카메라 뒤로 가면 앞으로 재배치
        if (transform.position.z < -30f)
        {
            transform.position += new Vector3(0, 0, 60f);
        }
    }
}
