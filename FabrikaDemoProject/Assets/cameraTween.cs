using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTween : MonoBehaviour {

	public Transform to;

	public void cameraTweener()
    {
		LeanTween.move(gameObject, to, 2f);
		LeanTween.rotate(gameObject, new Vector3 (8f,-90f,0), 2f);
    }

}

