using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatEffect : MonoBehaviour
{
    private void Start()
    {
        Invoke("ObjectDestroyerHAHAHAHAHA", 1);
    }

    private void ObjectDestroyerHAHAHAHAHA()
    {
        Destroy(gameObject);
    }
}
