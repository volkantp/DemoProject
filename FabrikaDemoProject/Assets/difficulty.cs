using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour {

    public static float hardness = 0.0f;
    private void Update()
    {
        hardness = Mathf.Lerp(hardness,1.0f,0.001f*Time.deltaTime);
    }

}
