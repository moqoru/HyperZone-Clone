using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float scrollSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -scrollSpeed * Time.deltaTime);

        if (transform.position.z < -10f)
        {
            Destroy(gameObject);
        }
    }
}
