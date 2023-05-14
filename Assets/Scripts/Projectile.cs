using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Start()
    {
        Invoke("ObjectDestroyerHAHAHAHAHA", 2);
        GetComponent<Rigidbody2D>().velocity = transform.up * 12;
    }

    private void ObjectDestroyerHAHAHAHAHA()
    {
        Destroy(gameObject);
    }
}
