using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gameEnding : MonoBehaviour {

    public UnityEvent gameOverEvent;
    public GameObject theInstantiator;
    
	public void gameEnd()
    {
        gameOverEvent.Invoke();
        theInstantiator.SetActive(false);
        Time.timeScale = 0.0f;
        scoreManager.score = 0;
    }

}
