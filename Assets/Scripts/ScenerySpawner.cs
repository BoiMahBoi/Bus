using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenerySpawner : MonoBehaviour
{

    public GameObject objectToBeSpawned;

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

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator spawnObject()
    {
        float spawnTime = Random.Range(minTime, maxTime);
        
        yield return new WaitForSeconds(spawnTime);
        GameObject newScenery = Instantiate(objectToBeSpawned, new Vector3(transform.position.x + 20, transform.position.y + spawnY, transform.position.z), transform.rotation);
        newScenery.transform.SetParent(gameObject.transform);
        StartCoroutine(spawnObject());
    }
}
