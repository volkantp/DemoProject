using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFrameRate : MonoBehaviour {

    // Use this for initialization
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
}
