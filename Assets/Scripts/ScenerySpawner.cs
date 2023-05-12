using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenerySpawner : MonoBehaviour
{

    public GameObject[] objectToBeSpawned;

    [Header("Spawn Coordinates")]
    public float spawnY;

    [Header("Spawn Timing")]
    public float minTime;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnObject());
    }


    public IEnumerator spawnObject()
    {
        float spawnTime = Random.Range(minTime, maxTime);
        
        yield return new WaitForSeconds(spawnTime);
        if(objectToBeSpawned.Length > 1)
        {
            GameObject newScenery = Instantiate(objectToBeSpawned[Random.Range(0, objectToBeSpawned.Length)], new Vector3(transform.position.x + 15, transform.position.y + spawnY, transform.position.z), transform.rotation);
            newScenery.transform.SetParent(gameObject.transform);
        }
        else
        {
            GameObject newScenery = Instantiate(objectToBeSpawned[0], new Vector3(transform.position.x + 20, transform.position.y + spawnY, transform.position.z), transform.rotation);
            newScenery.transform.SetParent(gameObject.transform);
        }
        StartCoroutine(spawnObject());
    }
}
