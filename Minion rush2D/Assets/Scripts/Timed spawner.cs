using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timedspawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
    }
}
