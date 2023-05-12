using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryMover : MonoBehaviour
{

    private void Start()
    {
        Invoke("ObjectDestroyerHAHAHAHAHA", 10);
    }

    private void FixedUpdate()
    {
        transform.position -= (transform.right) * Time.deltaTime * 3;
    }

    private void ObjectDestroyerHAHAHAHAHA()
    {
        Destroy(gameObject);
    }
}
