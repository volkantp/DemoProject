using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class killer : MonoBehaviour {


    void OnTriggerEnter(Collider com)
    {
        if (com.gameObject.tag == "gameover")
        {
            endTheGame();
        }
    }
    void endTheGame()
    {
        FindObjectOfType<gameEnding>().gameEnd();
    }
}
