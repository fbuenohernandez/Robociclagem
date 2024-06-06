using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back_forth : MonoBehaviour
{
    private Vector2 startPosition;
    private Vector2 endPosition;
    private float speed = 1.5f;
    private float distance = 75;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        endPosition = startPosition - new Vector2(distance, 0);
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector2.Lerp(startPosition, endPosition, time);
    }
}
