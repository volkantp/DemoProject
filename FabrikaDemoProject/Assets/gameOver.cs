using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "blade")
        {
            endGamePlay();
        }
    }
    public void endGamePlay()
    {
        //gameOver
    }
}
