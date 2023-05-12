using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour
{
    private Transform bus;

    // Start is called before the first frame update
    void Start()
    {
        bus = GameObject.Find("SasjaBus").GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //So the monsters move towards the bus. 
        transform.position = Vector3.MoveTowards(transform.position, bus.position, 5 * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("Bus"))
        {
            Debug.Log("Damage taken");
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(gameObject);
        }

    }
}
