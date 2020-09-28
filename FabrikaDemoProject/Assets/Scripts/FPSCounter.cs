using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FPSCounter : MonoBehaviour
{

    private int frameCounter = 0;
    private float timeCounter = 0.0f;
    public float refreshTime = 0.5f;
    [SerializeField]
    private Text framerateText;

    void Start()
    {
        // Make the game run as fast as possible
        //Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (timeCounter < refreshTime)
        {
            timeCounter += Time.deltaTime;
            frameCounter++;

        }
        else
        {
            float lastFramerate = frameCounter / timeCounter;
            frameCounter = 0;
            timeCounter = 0.0f;
            framerateText.text = lastFramerate.ToString("n2");
        }

    }
}
