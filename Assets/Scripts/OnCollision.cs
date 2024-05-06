using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour
{
    public string tagToCheck;
    public UnityEvent onCollision;

    private void OnCollisionEnter(Collision collision)
    {
        onCollision.Invoke();
    }
}
