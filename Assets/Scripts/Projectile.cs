using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void Start()
    {
        Invoke("ObjectDestroyerHAHAHAHAHA", 15);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.up * Time.deltaTime * 3;
    }

    private void ObjectDestroyerHAHAHAHAHA()
    {
        Destroy(gameObject);
    }
}
