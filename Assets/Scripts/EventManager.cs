using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Transform player;
    public Transform playerSpawner;

    public void killPlayer()
    {
        player.position = playerSpawner.position;
    }
}
