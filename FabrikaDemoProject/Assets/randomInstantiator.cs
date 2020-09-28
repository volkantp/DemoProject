using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomInstantiator : MonoBehaviour {

    public Vector3 spawningVector;
    [Range(0.5f,3f)]
    public float waitforRange = 1f;
    public GameObject[] trunks;
    public int randomIndex = 0;
    public int trunkSelectIndex = 0;
    public int trunkPositionIndex = 0;
    void OnDrawGizmos()
    {
        Gizmos.color = new Color (0,1,1, 0.5f);
        Gizmos.DrawCube(transform.position, spawningVector);
    }

    private void Start()
    {
        StartCoroutine(Counter());
    }
    public void Update()
    {
        waitforRange = waitforRange - difficulty.hardness / 100f;
        Physics.gravity = new Vector3(0,-20-difficulty.hardness*10f,0);
    }
    IEnumerator Counter()
    {
        creator();
        yield return new WaitForSeconds(waitforRange);
        trunkSelectIndex = Random.Range(0, trunks.Length);
        trunkPositionIndex = Random.Range(-7, 7);
        StartCoroutine(Counter());
    }
    private void creator()
    {
        Instantiate(trunks[trunkSelectIndex], new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, trunkPositionIndex), gameObject.transform.rotation);
    }

}
