using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObject : MonoBehaviour {

    public GameObject prefabFromChange;
    public GameObject prefabToChange;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "blade")
        {
            scoreManager.score++;
            prefabToChange.SetActive(true);
            prefabFromChange.SetActive(false);
            StartCoroutine(destroyer());
        }
    }
    IEnumerator destroyer()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
