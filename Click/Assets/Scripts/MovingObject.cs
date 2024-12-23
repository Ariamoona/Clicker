using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 startPos;
    private Vector3 endPos;
    private bool movingRight = true;

    private void Start()
    {
        startPos = transform.position;
        endPos = startPos + new Vector3(5, 0, 0); 
    }

    private void Update()
    {
        if (movingRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
            if (transform.position == endPos) movingRight = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
            if (transform.position == startPos) movingRight = true;
        }
    }
}
