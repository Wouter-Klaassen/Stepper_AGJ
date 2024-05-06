using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishManager : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    { 
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("GameOver");

        }
    }
}
