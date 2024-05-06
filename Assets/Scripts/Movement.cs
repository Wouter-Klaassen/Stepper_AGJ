using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform objectPosition;
    public float speed = 1f;

    public void moveOneTile(Vector3 direction)
    {
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            direction.y = 0;
        }
        else
        {
            direction.x = 0;
        }

        Vector3 nextPos = objectPosition.position + direction.normalized * speed;
        objectPosition.position = Vector3.MoveTowards(objectPosition.position, nextPos, speed * Time.deltaTime);
    }
}

