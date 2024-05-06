using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform objectPosition;
    public float speed = 1f;

    private void Update()
    {
        roundPosition();
    }

    public void moveOneTile(Vector3 direction)
    {
        Debug.Log(direction.normalized);
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            direction.y = 0;
        }
        else
        {
            direction.x = 0;
        }

        Vector3 nextPos = objectPosition.position + direction.normalized * speed;
        objectPosition.position = Vector3.MoveTowards(objectPosition.position, nextPos, 1f);
        roundPosition();
    }

    public void roundPosition()
    {
        Vector3 pos = objectPosition.position;
        objectPosition.position = new Vector3(RoundToNearestHalf(pos.x), RoundToNearestHalf(pos.y), 0.0f);

    }
    float RoundToNearestHalf(float num)
    {
        // Round to the nearest 0.5 value but not to a whole number
        float rounded = Mathf.Round(num * 2f) / 2f;
        if (Mathf.Abs(rounded - Mathf.Round(num)) < Mathf.Epsilon)
        {
            if (rounded > num)
                rounded -= 0.5f;
            else
                rounded += 0.5f;
        }
        return rounded;
    }
}

