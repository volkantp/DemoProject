using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using EZCameraShake;
public class prefabChanger : MonoBehaviour {

    public GameObject particleSpawnPos;
    public GameObject[] particlePrefabs;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "log")
        {
            CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
            for (int i =0; i<particlePrefabs.Length; i++)
            {
            Instantiate(particlePrefabs[i], particleSpawnPos.transform.position, particleSpawnPos.transform.rotation);
            }
        }
    }
}
