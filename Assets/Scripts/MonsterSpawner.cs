using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [Header("Spawn Coordinates")]
    public float minX;
    public float maxX;


    [Header("Spawn Timing")]
    public float minTime;
    public float maxTime;

    public GameObject[] monsters;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMonsters());
        
    }

    public IEnumerator spawnMonsters()
    {
        float spawnTime = Random.Range(minTime, maxTime);

        yield return new WaitForSeconds(spawnTime);
        GameObject newMonster = Instantiate(monsters[Random.Range(0, 2)], new Vector3(transform.position.x + Random.Range(minX, maxX), transform.position.y + 10, transform.position.z), transform.rotation);
        newMonster.transform.SetParent(gameObject.transform);
        StartCoroutine(spawnMonsters());
    }
}
