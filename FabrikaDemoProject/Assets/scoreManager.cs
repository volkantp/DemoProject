using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
	[SerializeField]
	public static int score = 0;
    public Text text;
    public void Update()
    {
        text.text = score.ToString();
    }
}
