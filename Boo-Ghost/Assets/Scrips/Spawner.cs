using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public GameObject spawnToObject;

    public float timeToSpawn;
    private float currenttiemtoSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currenttiemtoSpawn > 0)
        {
            currenttiemtoSpawn -= Time.deltaTime;
        }

        else
        {
            SpawnObject();
            currenttiemtoSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        Instantiate(ObjectToSpawn, transform.position, transform.rotation);
    }
}
