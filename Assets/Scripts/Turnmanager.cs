using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turnmanager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isPlayerTurn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");
        if (isPlayerTurn)
        {

        }
    }
}
