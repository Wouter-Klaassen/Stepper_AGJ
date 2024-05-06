using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Turnmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayerTurn;
    public Movement player;
    public Movement[] enemies;

    float xInput = 0;
    float yInput = 0;
    float stepsTaken = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        if (isPlayerTurn) movePlayer();
        else moveEnemies();
    }

    void movePlayer()
    {
        if(xInput != 0 || yInput != 0)
        {
            player.moveOneTile(new Vector3(xInput, yInput));
            stepsTaken++;
            Debug.Log(stepsTaken);
            isPlayerTurn = false;
        }
    }
    void moveEnemies()
    {

    }
}
