using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrolling : MonoBehaviour
{
    public Vector2 startPosition;
    public float scrollSpeed;
    public float xDistance;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {

        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, xDistance);
        transform.position = startPosition + Vector2.right * newPosition;

    }
    
}
