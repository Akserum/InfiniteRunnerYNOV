using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private int offSet = 100;
    SpawnerManager spawnerManager;

    private void Start()
    {
        spawnerManager = GameObject.Find("SpawnerManager").GetComponent<SpawnerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(spawnerManager.platform, new Vector3(0, 0, gameObject.transform.position.z + offSet), Quaternion.identity);
        }
    }
}
