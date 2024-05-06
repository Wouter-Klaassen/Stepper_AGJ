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
    public static float stepsTaken = 0;

    float turnPauser;
    public float pauseBy = 5;

    void Start()
    {
        turnPauser = pauseBy;
    }

    // Update is called once per frame
    void Update()
    {
        if(turnPauser <= 0)
        {
            xInput = Input.GetAxisRaw("Horizontal");
            yInput = Input.GetAxisRaw("Vertical");
            if (isPlayerTurn) movePlayer();
            else moveEnemies();
        }
        else
        {
            turnPauser -= Time.deltaTime;
        }
    }

    void movePlayer()
    {
        if(xInput != 0 || yInput != 0)
        {
            player.moveOneTile(new Vector3(xInput, yInput));
            stepsTaken++;
            turnPauser = pauseBy;
        }
    }
    void moveEnemies()
    {
        turnPauser = pauseBy;
    }
}
