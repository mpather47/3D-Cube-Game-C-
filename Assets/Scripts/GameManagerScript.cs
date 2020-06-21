using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    bool edge = false;
    public void EndGame()
    {
        if (edge = false)
        {
            edge = true;
            Debug.Log("Game Over");
        }
        
    }
}
