using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManeger : MonoBehaviour
{

    void Update()
    {
        if (playerstats.Lives <= 0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        Debug.Log("Game Over");
    }
}
